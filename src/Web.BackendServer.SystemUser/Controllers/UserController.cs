using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortNet.Data.Repositories;
using PortNet.Model.Entities.INFPort;

namespace Web.BackendServer.SystemUser.Controllers
{
    public class UserController : BaseController
    {
        private readonly UserManager<Users> _userManager;
        private readonly IUserRepository _userRepository;

        public UserController(UserManager<Users> userManager, IUserRepository userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("/user/{userId}/role")]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound();
            var roles = await _userManager.GetRolesAsync(user);
            return Ok(roles);
        }

        [HttpGet]
        [Route("/user/{userId}/menu")]
        public async Task<IActionResult> GetMenuByUser(string userId)
        {
            var result = await _userRepository.GetMenuByUser(userId);
            return Ok(result);
        }
    }
}
