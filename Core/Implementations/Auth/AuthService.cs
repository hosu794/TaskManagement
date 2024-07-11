using Core.Interfaces.Auth;
using Core.Models.Auth;
using Data.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Implementations.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;

        public AuthService(ITokenService tokenService) {
        
           
            _tokenService = tokenService;
        }

        public async Task<string> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegisterUser(RegisterRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
