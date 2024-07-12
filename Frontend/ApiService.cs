using Core.Models.Auth;
using Microsoft.AspNetCore.Authentication.OAuth;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using TaskManagement.Core.Models.User;
using LoginRequestDto = Core.Models.Auth.LoginRequestDto;

namespace Frontend
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationDelegatingHandler _authHandler;
        private string _token;

        public ApiService(HttpClient httpClient, AuthenticationDelegatingHandler authenticationDelegatingHandler)
        {
            _httpClient = httpClient;
            _authHandler = authenticationDelegatingHandler;
        }

        public async Task<bool> Register(string username, string password, bool isManager)
        {
            var registerRequest = new RegisterRequestDto
            {
                Username = username,
                Password = password,
                IsManager = isManager
            };

            var response = await _httpClient.PostAsJsonAsync("api/user/register", registerRequest);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var registerResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenResponse>(content);
                _authHandler.SetToken(registerResponse.Token);
                _token = registerResponse.Token;
                return true;
            }

            return false;
        }

        public async Task<bool> Login(string username, string password)
        {
            var loginRequest = new LoginRequestDto
            {
                Username = username,
                Password = password
            };

            var response = await _httpClient.PostAsJsonAsync("api/user/login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var loginResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenResponse>(content);
                _authHandler.SetToken(loginResponse.Token);
                _token = loginResponse.Token;
                return true;
            }

            return false;
        }

        public async Task<UserResponse> GetCurrentUser()
        {

            var response = await _httpClient.GetAsync("api/user/current");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<UserResponse>(content);
            }

            return null;
        }

    }
}
