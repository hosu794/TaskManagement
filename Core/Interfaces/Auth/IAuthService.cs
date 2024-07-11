using Core.Models.Auth;

namespace Core.Interfaces.Auth
{
    public interface IAuthService
    {
        public Task<bool> RegisterUser(RegisterRequestDto registerRequestDto);
        public Task<string>Login (LoginRequestDto loginRequestDto);
    }
}
