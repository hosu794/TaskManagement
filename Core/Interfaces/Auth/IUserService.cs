using Core.Models.Auth;
using TaskManagement.Core.Models.User;

namespace Core.Interfaces.Auth
{
    public interface IUserService
    {
        Task<TokenResponse> RegisterUser(RegisterRequestDto registerRequestDto);
        Task<TokenResponse>Login (LoginRequestDto loginRequestDto);
        Task<UserResponse> GetUser(int userId);
        Task<bool> IsExistsByUsername(string username);
    }
}
