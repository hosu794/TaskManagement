using Core.Models.Auth;
using TaskManagement.Core.Models.Manager;
using TaskManagement.Core.Models.User;

namespace Core.Interfaces.Auth
{
    public interface IUserRepository
    {
        Task<UserRepositoryResponse?> CreateUser(RegisterRequestDto request);
        Task<UserRepositoryResponse?> GetUser(LoginRequestDto request);
        Task<bool> IsUserExistsById(int userId);
        Task<UserResponse> GetUser(int userId);
        Task<bool> IsUserExistsByUsername(string username);
        Task<List<UserResponse>> GetAllUsers();
        Task<bool> AssignManagerToUser(int userId, int managerId);
        Task<List<UserResponse>> GetAllManagers();
    }
}
