﻿using Core.Implementations.Task;
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

        public async Task<TaskResponse> CreateTask(TaskRepositoryDto task)
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

            return new TaskResponse()
            {
                Id = newTask.Id,
                CreatedAt = newTask.CreatedAt,
                CreatedBy = newTask.UserId,
                Name = string.Empty,
                Description = newTask.Description,
                UpdatedAt = newTask.UpdatedAt
            };
        }

        public async Task<bool> DeleteTask(int taskId)
        {
            var taskToRemove = await _context.TaskTodos.FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToRemove == null) return false;

            _context.Remove(taskToRemove);

            return true;
        }

        public Task<List<TaskResponse>> GetTaskByUserId(int userId)
        {
            return _context.TaskTodos.AsNoTracking()
                .Where(x => x.UserId == userId)
                .Select(x => new TaskResponse()
                {
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.UserId,
                    Description = x.Description,
                    Id = x.Id,
                    Name = string.Empty,
                    UpdatedAt = x.UpdatedAt 
                }).ToListAsync();
        }

        public async Task<List<TaskResponse>> GetTaskSharedByUser(int userId)
        {
            return await _context.TaskTodos
        }

        public Task<List<TaskResponse>> GetTaskSharedForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<TaskResponse> UpdateTask(TaskRepositoryDto task, int taskId)
        {
            var taskToUpdate = await _context.TaskTodos.FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToUpdate == null) throw new Exception($"Task not found with given id: {taskId}");

            taskToUpdate.PriorityId = task.PriorityId;
            taskToUpdate.Description = task.Description;
            taskToUpdate.UpdatedAt = DateTime.Now;

            _context.Entry(taskToUpdate).Property(p => p.PriorityId).IsModified = true;
            _context.Entry(taskToUpdate).Property(p => p.Description).IsModified = true;
            _context.Entry(taskToUpdate).Property(p => p.UpdatedAt).IsModified = true;

            await _context.SaveChangesAsync();

            return new TaskResponse()
            {
                Id = taskToUpdate.Id,
                CreatedAt = taskToUpdate.CreatedAt,
                CreatedBy = taskToUpdate.UserId,
                Name = string.Empty,
                Description = taskToUpdate.Description,
                UpdatedAt = taskToUpdate.UpdatedAt
            };

        }

        
    }
}
 