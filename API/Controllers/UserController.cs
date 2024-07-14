using Core.Extensions;
using Core.Interfaces.Auth;
using Core.Models.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService authService)
        {
            _userService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto request)
        {

            var response = await _userService.RegisterUser(request);

            if (response == null) return BadRequest("Given username already exists");

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            var response = await _userService.Login(request);

            if (response == null) return BadRequest();
            return Ok(response);
        }

        [Authorize]
        [ManagerOnly]
        [HttpGet("manager")]
        public IActionResult GetManagerAuth()
        {
            return Ok("Dane dostępne tylko dla managerów");
        }

        [Authorize]
        [HttpGet("current")]
        public async Task<IActionResult> GetCurrentLoggedUser()
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await _userService.GetUser(parsedIntUserId));
        }

        [HttpGet("user/exists")]
        public async Task<IActionResult> IsExistsByUsername([FromQuery] string username)
        {
            return Ok(await _userService.IsExistsByUsername(username));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsers());
        }
    }
}
