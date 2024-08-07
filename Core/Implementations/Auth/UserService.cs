﻿using Core.Interfaces.Auth;
using Core.Models.Auth;
using Microsoft.AspNetCore.Identity;
using TaskManagement.Core.Models.User;
using TaskManagement.Data.DbModels;

namespace Core.Implementations.Auth
{
    public class UserService : IUserService
    {
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(ITokenService tokenService, IUserRepository authRepository, IPasswordHasher<User> passwordHasher)
        {

            _userRepository = authRepository;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        public async Task<TokenResponse> Login(LoginRequestDto loginRequestDto)
        {
            var userResult = await _userRepository.GetUser(loginRequestDto);

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

            var isUsernameExists = await _userRepository.IsUserExistsByUsername(registerRequestDto.Username);

            if (isUsernameExists) return null;

            var registerResponse = await _userRepository.CreateUser(registerRequestDto);

            var token = _tokenService.GenerateToken(registerResponse);

            return new TokenResponse()
            {
                IsManager = registerResponse.IsManager,
                Token = token
            };

        }

        public async Task<UserResponse> GetUser(int userId)
        {
            return await _userRepository.GetUser(userId);
        }

        public async Task<bool> IsExistsByUsername(string username)
        {
            return await _userRepository.IsUserExistsByUsername(username);
        }

        public async Task<List<UserResponse>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<bool> AssignUserToManager(int userId, int managerId)
        {
            return await _userRepository.AssignManagerToUser(userId, managerId);
        }

        public async Task<List<UserResponse>> GetAllManagers()
        {
            return await _userRepository.GetAllManagers();
        }
    }
}
