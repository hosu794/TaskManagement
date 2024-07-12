using Core.Models.Auth;
using Data.DbModels;

namespace Core.Interfaces.Auth
{
    public interface IUserRepository
    {
        Task<UserRepositoryResponse?> CreateUser(RegisterRequestDto request);
        Task<UserRepositoryResponse?> GetUser(LoginRequestDto request);
        Task<bool> IsUserExistsById(int userId);
    }
}
