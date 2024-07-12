using Core.Models.Auth;

namespace Core.Interfaces.Auth
{
    public interface IAuthService
    {
        public Task<TokenResponse> RegisterUser(RegisterRequestDto registerRequestDto);
        public Task<TokenResponse>Login (LoginRequestDto loginRequestDto);
    }
}
