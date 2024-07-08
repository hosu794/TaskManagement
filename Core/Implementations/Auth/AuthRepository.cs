using Core.Interfaces.Auth;
using Core.Models.Auth;
using Data;

namespace Core.Services.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly TaskManagerDbContext _context;

        public AuthRepository(TaskManagerDbContext context)
        {
            _context = context;
        }
        public Task<string> Login(LoginRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponseDto> Register(RegisterRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
