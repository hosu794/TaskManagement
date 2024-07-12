using Core.Interfaces.Auth;
using Core.Models.Auth;
using Data;
using Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Auth
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskManagerDbContext _context;


        public UserRepository(TaskManagerDbContext context)
        {
            _context = context;
        }
        public async Task<UserRepositoryResponse?> GetUser(LoginRequestDto request)
        {
            User? user = await _context.Users.
                FirstOrDefaultAsync(x => x.Username == request.Username);

            if (user == null) return null;

            Manager? manager = await _context.Managers.FirstOrDefaultAsync(x => x.UserId == user.Id);

            UserRepositoryResponse? response = new UserRepositoryResponse()
            {
                Id = user.Id,
                Password = user.Password,
                UserName = user.Username,
            };

            if (manager != null)
            {
                response.IsManager = true;
            }

            return response;
        }

        public async Task<UserRepositoryResponse?> CreateUser(RegisterRequestDto request)
        {
            User user = new User()
            {
                Username = request.Username,
                Password = request.Password
            };

            await _context.AddAsync(user);

            await _context.SaveChangesAsync();

            if (request.IsManager)
            {
                Manager manager = new Manager()
                {
                    UserId = user.Id
                };

                await _context.AddAsync(manager);
                await _context.SaveChangesAsync();
            }

            return new UserRepositoryResponse()
            {
                Id = user.Id,
                Password = user.Password,
                UserName = user.Username,
                IsManager = request.IsManager
            };

        }

        public async Task<bool> IsUserExistsById(int userId)
        {
            return await _context.Users.AnyAsync(x => x.Id == userId);
        }
    }
}
