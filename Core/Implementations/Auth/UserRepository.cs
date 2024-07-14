using Core.Interfaces.Auth;
using Core.Models.Auth;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Core.Models.User;
using TaskManagement.Data;
using TaskManagement.Data.DbModels;

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

        public async Task<UserResponse> GetUser(int userId)
        {
            var user = await _context.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == userId);

            if (user == null) return new UserResponse();


            var response = new UserResponse()
            {
                Id = user.Id,
                Username = user.Username,
            };


            var manager = await _context.Managers.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == userId);

            if (manager != null)
            {
                response.IsManager = true;
            }

            return response;
        }

        public async Task<bool> IsUserExistsByUsername(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username == username);
        }

        public async Task<List<UserResponse>> GetAllUsers()
        {
            return await _context.Users.AsNoTracking()
                .Select(u => new UserResponse()
                {
                    Id = u.Id,
                    Username = u.Username,
                    IsManager = 
                }).ToListAsync();
        }
    }
}
