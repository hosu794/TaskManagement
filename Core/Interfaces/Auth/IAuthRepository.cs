using Core.Models.Auth;

namespace Core.Interfaces.Auth
{
    public interface IAuthRepository
    {
        Task<UserResponseDto> Register(RegisterRequestDto request);
        Task<string> Login(LoginRequestDto request);
    }
}
