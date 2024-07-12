using Core.Extensions;
using Core.Interfaces.Auth;
using Core.Models.Auth;
using Data.DbModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto request) { 
        
            var response =  await _authService.RegisterUser(request);
        
            if (response == null) return BadRequest();

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            var response = await _authService.Login(request);

            if (response == null) return BadRequest(); 
            return Ok(response);
        }


        [Authorize]
        [ManagerOnly]
        [HttpGet("manager")]
        public IActionResult GetManagerData()
        {
            // Logika dostępna tylko dla managerów
            return Ok("Dane dostępne tylko dla managerów");
        }

        [HttpGet("auth")]
        [Authorize]
        public IActionResult GetAuth()
        {
            // Logika dostępna tylko dla managerów
            return Ok("Dane dostępne tylko dla zautoryzowanych uzytkownikow.");
        }


    }
}
