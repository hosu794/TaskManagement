using Core.Models.Auth;
using Data.DbModels;

namespace Core.Interfaces.Auth
{
    public interface IAuthRepository
    {
        Task<UserRepositoryResponse?> CreateUser(RegisterRequestDto request);
        Task<UserRepositoryResponse?> GetUser(LoginRequestDto request);
    }
}
