using Core.Implementations.Task;
using Core.Models.Task;
using Data;
using Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces.Task
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerDbContext _context;

        public TaskRepository(TaskManagerDbContext context)
        {
            _context = context;
        }

        public async Task<TaskTodo> CreateTask(TaskRepositoryDto task)
        {
            var newTask = new TaskTodo()
            {
                CreatedAt = DateTime.Now,
                Description = task.Description,
                PriorityId = task.PriorityId,
                UserId = task.UserId,
            };

            await _context.AddRangeAsync(newTask);
            await _context.SaveChangesAsync();

            return newTask;
        }

        public async Task<bool> DeleteTask(int taskId)
        {
            var taskToRemove = await _context.TaskTodos.FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToRemove == null) return false;

            _context.Remove(taskToRemove);

            return true;
        }

        
    }
}
 