using Dapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PortNet.Data.Infrastructure;
using PortNet.Data.Migrations.INFPortDbContext;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Model.Entities.INFPort;
using PortNet.Model.Models.Authentication;
using PortNet.Service.Helpers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PortNet.Data.Repositories
{
    public interface IUserRepository : IRepository<Users>
    {
        Task<IEnumerable<Users>> GetUsers(string userName, string password);
        AuthenticateViewModel Authenticate(AuthenticateRequest model);
        Task<List<INSFunctions>> GetMenuByUser(string userId);
    }

    public class UserRepository : RepositoryBase<Users>, IUserRepository
    {
        private readonly INFPortObjectDbContext _portObjectDbContext;
        private readonly INFPortDbContext _portDbContext;
        private readonly IDapper _dapper;
        private readonly AppSettings _appSettings;
        private readonly UserManager<Users> _userManager;

        public UserRepository(INFPortObjectDbContext portObjectDbContext,
            INFPortDbContext portDbContext,
            IDapper dapper,
            IOptions<AppSettings> appSettings,
            UserManager<Users> userManager) : base(portObjectDbContext)
        {
            _portObjectDbContext = portObjectDbContext;
            _portDbContext = portDbContext;
            _dapper = dapper;
            _appSettings = appSettings.Value;
            _userManager = userManager;
        }

        public AuthenticateViewModel Authenticate(AuthenticateRequest model)
        {
            var user = GetUsers(model.UserName, HashPassword.GetSwcSHA1(model.Password)).Result.FirstOrDefault();

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = GenerateJwtToken(user);

            return new AuthenticateViewModel(user, token);
        }

        public async Task<List<INSFunctions>> GetMenuByUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);
            var query = (
                            from f in _portDbContext.INSFunctions
                            join r in _portDbContext.Rules on f.Id equals r.FunctionId
                            join g in _portDbContext.Groups on r.GroupId equals g.ID
                            where roles.Contains(g.GroupName)
                            select new INSFunctions
                            {
                                Id = f.Id,
                                Description = f.Description,
                                Date = f.Date,
                                IsType = f.IsType,
                                Level = f.Level,
                                Level_1 = f.Level_1,
                                Param = f.Param,
                                Parent = f.Parent,
                                RefPath = f.RefPath,
                                RefPathNew = f.RefPathNew,
                                Type = f.Type,
                                Visible = f.Visible
                            }
                         );

            var data = await query.Distinct().OrderBy(x => x.Parent).ThenBy(x => x.Level_1).ToListAsync();

            return data;
        }

        public async Task<IEnumerable<Users>> GetUsers(string userName, string password)
        {
            var paramaters = new DynamicParameters();
            paramaters.Add("@UserID", userName);
            paramaters.Add("@Password", password);
            var result = await Task.FromResult(_dapper.GetAll<Users>("fpt_spGetLoginUsers", paramaters, System.Data.CommandType.StoredProcedure, _connInfPort));
            return result.Result;
        }

        private string GenerateJwtToken(Users user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}