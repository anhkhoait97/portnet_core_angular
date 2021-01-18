using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PortNet.Data.Migrations.INFPortDbContext;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Data.Repositories;
using PortNet.Model.Entities.INFPort;
using PortNet.Service.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.BackendServer.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<Users> _signInManager;
        private readonly INFPortObjectDbContext _portObjectDbContext;
        private readonly INFPortDbContext _portDbContext;
        private readonly ILogger<LoginModel> _logger;
        private readonly IUserRepository _userRepository;

        public LoginModel(SignInManager<Users> signInManager,
            ILogger<LoginModel> logger,
            UserManager<Users> userManager,
            IUserRepository userRepository,
            RoleManager<IdentityRole> roleManager,
            INFPortObjectDbContext portObjectDbContext,
            INFPortDbContext portDbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _logger = logger;
            _userRepository = userRepository;
            _portObjectDbContext = portObjectDbContext;
            _portDbContext = portDbContext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // check Model State
            if (ModelState.IsValid)
            {
                // check user name and pass in inside
                var hashString = HashPassword.GetSwcSHA1(Input.Password);
                Users users = _userRepository.GetUsers(Input.UserName, hashString).Result.FirstOrDefault();
                if (users != null)
                {
                    // check user in identity if not exist than create new
                    var userExist = await CheckUserExist(users);
                    if (userExist != null)
                    {
                        var groupGet = await (from g in _portDbContext.Groups
                                              join ug in _portDbContext.UserGroups.Where(x => x.UserId == users.UserId)
                                              on g.ID equals ug.GroupId
                                              select g).ToListAsync();
                        foreach (var item in groupGet)
                        {
                            await CheckGroupExist(item.GroupName);
                            await CheckUserGroupExist(userExist.UserId, item.GroupName);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        /// <summary>
        /// CheckUserExist
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<Users> CheckUserExist(Users users)
        {
            if (!_userManager.Users.Any(x => x.UserName == Input.UserName))
            {
                users.Id = Guid.NewGuid().ToString();
                users.UserName = users.UserId;
                users.Password = users.Password;
                users.NormalizedEmail = users.Email.ToUpper();
                users.LockoutEnabled = false;
                await _userManager.CreateAsync(users, Input.Password);
                var data = await _portObjectDbContext.SaveChangesAsync();
            }
            return users;
        }

        /// <summary>
        /// CheckGroupExist
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public async Task<bool> CheckGroupExist(string groupName)
        {
            bool flag = false;
            if (!await _roleManager.RoleExistsAsync(groupName))
            {
                IdentityRole newRole = new IdentityRole();
                newRole.Name = groupName;
                flag = (await _roleManager.CreateAsync(newRole)).Succeeded;
                await _portObjectDbContext.SaveChangesAsync();
            }

            return flag;
        }

        /// <summary>
        /// CheckUserGroupExist
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<bool> CheckUserGroupExist(string userName, string roleName)
        {
            bool flag = false;
            var user = await _userManager.FindByNameAsync(userName);
            if (!await _userManager.IsInRoleAsync(user, roleName))
            {
                var result = await _userManager.AddToRoleAsync(user, roleName);
                flag = result.Succeeded;
                await _portObjectDbContext.SaveChangesAsync();
            }
            return flag;
        }
    }
}