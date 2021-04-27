using System.Threading.Tasks;
using DTOs;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    public class AccountController : BaseController
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<ApiUser> _userManager;
        private readonly SignInManager<ApiUser> _signInManager;
        public AccountController(UserManager<ApiUser> userManager, SignInManager<ApiUser> signInManager, ITokenService tokenService)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._tokenService = tokenService;
        }
        // [Authorize]
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> RegisterUser(RegisterDto registerDto)
        {
            if (await UserExists(registerDto.UserName)) return BadRequest("UserName is taken");

            var user = new ApiUser
            {
                UserName = registerDto.UserName.ToLower(),
            };
            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if(!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "User");
            if(!roleResult.Succeeded) return BadRequest(result.Errors);
            
            return new UserDto
            {
                UserName = user.UserName,
                Token = await _tokenService.CreateToken(user),
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> LoginUser(LoginDto loginDto)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == loginDto.UserName.ToLower());
            if (user == null) return Unauthorized("Invalid UserName and/or password");
            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if(!result.Succeeded) return Unauthorized("Invalid UserName and/or password");

            return new UserDto
            {
                UserName = user.UserName,
                Token = await _tokenService.CreateToken(user),
            }; ;
        }
        private async Task<bool> UserExists(string UserName)
        {
            return await _userManager.Users.AnyAsync(x => x.UserName == UserName.ToLower());
        }

    }
}