using Core.Models.Auth;
using Data.DbModels;
using Data.Models;

namespace Core.Interfaces.Auth
{
    public interface ITokenService
    {
        string GenerateToken(UserRepositoryResponse user);
    }
}
