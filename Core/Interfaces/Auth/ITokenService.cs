using Core.Models.Auth;

namespace Core.Interfaces.Auth
{
    public interface ITokenService
    {
        string GenerateToken(UserRepositoryResponse user);
    }
}
