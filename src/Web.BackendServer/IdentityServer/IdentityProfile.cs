using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Model.Entities.INFPort;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.BackendServer.IdentityServer
{
    public class IdentityProfile : IProfileService
    {
        private readonly IUserClaimsPrincipalFactory<Users> _claimsFactory;
        private readonly UserManager<Users> _userManager;
        private readonly INFPortObjectDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityProfile(IUserClaimsPrincipalFactory<Users> claimsFactory,
            UserManager<Users> userManager,
            INFPortObjectDbContext context,
           RoleManager<IdentityRole> roleManager)
        {
            _claimsFactory = claimsFactory;
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var sub = context.Subject.GetSubjectId();
            // get user
            var user = await _userManager.FindByIdAsync(sub);
            if (user == null)
                throw new ArgumentException("");
            // get role use
            var roles = await _userManager.GetRolesAsync(user);
            var principal = await _claimsFactory.CreateAsync(user);
            var claims = principal.Claims.ToList();

            // add claims for user login
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
            claims.Add(new Claim(ClaimTypes.Role, string.Join(";", roles)));

            //var query = from p in _context.Permissions
            //            join c in _context.Commands
            //            on p.CommandId equals c.Id
            //            join f in _context.Functions
            //            on p.FunctionId equals f.Id
            //            join r in _roleManager.Roles on p.RoleId equals r.Id
            //            where roles.Contains(r.Name)
            //            select f.Id + "_" + c.Id;
            //var permissions = await query.Distinct().ToListAsync();
            //Add more claims like this

            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            context.IsActive = user != null;
        }
    }
}