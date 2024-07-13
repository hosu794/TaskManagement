using Core.Models.Auth;
using Core.Models.Priority;
using Core.Models.Task;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Identity.Client.NativeInterop;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using TaskManagement.Core.Models.User;
using TaskManagement.Data.DbModels;
using LoginRequestDto = Core.Models.Auth.LoginRequestDto;

namespace Frontend
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationDelegatingHandler _authHandler;

        public ApiService(HttpClient httpClient, AuthenticationDelegatingHandler authenticationDelegatingHandler)
        {
            _httpClient = httpClient;
            _authHandler = authenticationDelegatingHandler;
        }

        public async Task<TaskResponse> CreateTask(TaskRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/Task/tasks", request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<TaskResponse>(content);
            }

            return null;
        }

        public async Task<TaskResponse> UpdateTask(TaskRequest request, int taskId)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/Task/tasks?taskId={taskId}", request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<TaskResponse>(content);
            }

            return null;
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

        public async Task<List<TaskResponse>> GetAllTasks()
        {
            var response = await _httpClient.GetAsync("api/Task/tasks");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TaskResponse>>(content);
            }
            return new List<TaskResponse>();
        }

        public async Task<List<PriorityResponse>> GetAllPriorities()
        {
            var response = await _httpClient.GetAsync("api/Priority/priorities");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<PriorityResponse>>(content);
            }

            return new List<PriorityResponse>();

        }
    }
}
