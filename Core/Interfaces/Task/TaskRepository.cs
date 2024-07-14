using Core.Implementations.Task;
using Core.Models.Task;

using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskManagement.Core.Models.Manager;
using TaskManagement.Data;
using TaskManagement.Data.DbModels;

namespace Core.Interfaces.Task
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerDbContext _context;

        public TaskRepository(TaskManagerDbContext context)
        {
            _context = context;
        }

        public async Task<TaskResponse> CreateTask(TaskRepositoryDto task)
        {
            var newTask = new TaskTodo()
            {
                CreatedAt = DateTime.Now,
                Description = task.Description,
                Title = task.Name,
                PriorityId = task.PriorityId,
                UserId = task.UserId,
                UpdatedAt = DateTime.Now
            };

            await _context.AddRangeAsync(newTask);
            await _context.SaveChangesAsync();

            var priority = await _context.Priorities.FirstOrDefaultAsync(x => x.Id == newTask.PriorityId);

            if (priority == null) throw new Exception("Priority not found");

            return new TaskResponse()
            {
                Id = newTask.Id,
                CreatedAt = newTask.CreatedAt,
                CreatedBy = newTask.UserId,
                Name = newTask.Title,
                Description = newTask.Description,
                UpdatedAt = newTask.UpdatedAt,
                PriorityId = newTask.PriorityId,
                PriorityName = priority.Name
            };
        }

        public async Task<bool> DeleteTask(int taskId, int userId)
        {

            var taskToRemove = await _context.TaskTodos
                .Include(t => t.Users)
                .FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToRemove == null) return false;
            
            if (taskToRemove.UserId != userId) return true;

            taskToRemove.Users.Clear();

            _context.Remove(taskToRemove);

            await _context.SaveChangesAsync(true);

            return true;
        }

        public async Task<List<TaskStatistics>> GetAllStatisticsByUserId(int managerId)
        {
            var manager = await _context.Managers.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == managerId);

            if (manager == null) throw new Exception("Manager with user id doesnt exists!");
            
            return await _context.GetTaskStatisticsByManagerAsync(manager.UserId);
        }

        public async Task<List<UserManagerTaskResponse>> GetAllUserTasksForManagerByUserId(int userId)
        {
            return await _context.Managers.AsNoTracking()
            .Where(x => x.UserId == userId)
            .SelectMany(x => x.Users)
            .SelectMany(u => u.TaskTodos.Select(t => new UserManagerTaskResponse
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                Description = t.Description,
                Name = t.Title,
                PriorityId = t.PriorityId,
                PriorityName = t.Priority.Name,
                UserId = u.Id,
                Username = u.Username
            }))
            .ToListAsync();
        }

        public Task<List<TaskResponse>> GetTaskByUserId(int userId)
        {
            return _context.TaskTodos.AsNoTracking()
                .Include(x => x.Priority)
                .Where(x => x.UserId == userId)
                .Select(x => new TaskResponse()
                {
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.UserId,
                    Description = x.Description,
                    Id = x.Id,
                    Name = x.Title,
                    UpdatedAt = x.UpdatedAt,
                    PriorityId = x.PriorityId,
                    PriorityName = x.Priority.Name
                }).ToListAsync();
        }

        public async Task<List<TaskResponse>> GetTaskSharedByUser(int userId)
        {
            return await _context.TaskTodos.AsNoTracking()
                .Include(x => x.Priority)
                .Include(x => x.Users)
                .Where(x => x.Users.Count > 0 && x.UserId == userId)
                .Select(x => new TaskResponse()
                {
                    Id = x.Id,
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.UserId,
                    Name = x.Title,
                    Description = x.Description,
                    UpdatedAt = x.UpdatedAt,
                    PriorityName = x.Priority.Name
                }).ToListAsync();
        }

        public async Task<List<TaskResponse>> GetTaskSharedForUser(int userId)
        {
            return await _context.Users.AsNoTracking()
               .Include(x => x.SharedTasks)
               .ThenInclude(x => x.Priority)
               .Where(x => x.SharedTasks.Count > 0 && x.Id == userId)
               .SelectMany(x => x.SharedTasks)
               .Select(x => new TaskResponse()
               {
                   Id = x.Id,
                   CreatedAt = x.CreatedAt,
                   CreatedBy = x.UserId,
                   Name = x.Title,
                   Description = x.Description,
                   UpdatedAt = x.UpdatedAt,
                   PriorityId = x.Priority.Id,
                   PriorityName = x.Priority.Name
               }).ToListAsync();
        }

        public async Task<TaskResponse> ShareTask(int taskId, int userId)
        {
            var taskToShare = await _context.TaskTodos
             .Include(x => x.Users)
             .Include(x => x.Priority)
             .FirstOrDefaultAsync(x => x.Id == taskId);
            if (taskToShare == null) throw new Exception("Task to share not found.");

            var userToShareTask = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userToShareTask == null) throw new Exception("User to share not found.");

            if (!taskToShare.Users.Any(u => u.Id == userId))
            {
                taskToShare.Users.Add(userToShareTask);
                await _context.SaveChangesAsync();
            }

            return new TaskResponse()
            {
                Id = taskToShare.Id,
                CreatedAt = taskToShare.CreatedAt,
                CreatedBy = taskToShare.UserId,
                Name = taskToShare.Title,
                Description = taskToShare.Description,
                UpdatedAt = taskToShare.UpdatedAt,
                PriorityId= taskToShare.Priority.Id,
                PriorityName = taskToShare.Priority.Name
            };
        }

        public async Task<TaskResponse> UpdateTask(TaskRepositoryDto task, int taskId)
        {
            var taskToUpdate = await _context.TaskTodos.FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToUpdate == null) throw new Exception($"Task not found with given id: {taskId}");

            taskToUpdate.PriorityId = task.PriorityId;
            taskToUpdate.Description = task.Description;
            taskToUpdate.UpdatedAt = DateTime.Now;
            taskToUpdate.Title = task.Name;

            _context.Entry(taskToUpdate).Property(p => p.PriorityId).IsModified = true;
            _context.Entry(taskToUpdate).Property(p => p.Description).IsModified = true;
            _context.Entry(taskToUpdate).Property(p => p.UpdatedAt).IsModified = true;
            _context.Entry(taskToUpdate).Property(p => p.Title).IsModified = true;

            var priority = await _context.Priorities.FirstOrDefaultAsync(x => x.Id == taskToUpdate.PriorityId);

            if (priority == null) throw new Exception("Priority not found");

            await _context.SaveChangesAsync();

            return new TaskResponse()
            {
                Id = taskToUpdate.Id,
                CreatedAt = taskToUpdate.CreatedAt,
                CreatedBy = taskToUpdate.UserId,
                Name = taskToUpdate.Title,
                Description = taskToUpdate.Description,
                UpdatedAt = taskToUpdate.UpdatedAt,
                PriorityId = taskToUpdate.PriorityId,
                PriorityName = priority.Name
            };

        }


    }
}
 