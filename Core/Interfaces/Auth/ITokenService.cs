using Data.Models;

namespace Core.Interfaces.Auth
{
    public interface ITokenService
    {
        string GenerateToken(User user, IList<string> roles);
    }
}
