using Core.Interfaces.Auth;
using Core.Models.Auth;
using Data.DbModels;
using Microsoft.AspNetCore.Identity;

namespace Core.Implementations.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthService(ITokenService tokenService, IAuthRepository authRepository, IPasswordHasher<User> passwordHasher)
        {

            _authRepository = authRepository;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        public async Task<TokenResponse> Login(LoginRequestDto loginRequestDto)
        {
            var userResult = await _authRepository.GetUser(loginRequestDto);

            if (userResult == null) throw new Exception("User with given login not exists!");

            var result = _passwordHasher.VerifyHashedPassword(null, userResult.Password, loginRequestDto.Password);

            if (result == PasswordVerificationResult.Failed) throw new Exception("Incorrect password");

            var token = _tokenService.GenerateToken(userResult);

            return new TokenResponse()
            {
                IsManager = userResult.IsManager,
                Token = token
            };
        }

        public async Task<TokenResponse> RegisterUser(RegisterRequestDto registerRequestDto)
        {

            registerRequestDto.Password = _passwordHasher.HashPassword(null, registerRequestDto.Password);

            var registerResponse = await _authRepository.CreateUser(registerRequestDto);

            var token = _tokenService.GenerateToken(registerResponse);

            return new TokenResponse()
            {
                IsManager = registerResponse.IsManager,
                Token = token
            };

        }
    }
}
