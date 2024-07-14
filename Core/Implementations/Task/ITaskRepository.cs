﻿using Core.Models.Task;
using TaskManagement.Core.Models.Manager;

namespace Core.Implementations.Task
{
    public interface ITaskRepository
    {
        Task<TaskResponse> CreateTask(TaskRepositoryDto task);
        Task<bool> DeleteTask(int taskId, int userId);
        Task<TaskResponse> UpdateTask(TaskRepositoryDto task, int taskId);
        Task<List<TaskResponse>> GetTaskByUserId(int userId);
        Task<List<TaskResponse>> GetTaskSharedForUser(int userId);
        Task<List<TaskResponse>> GetTaskSharedByUser(int userId);
        Task<TaskResponse> ShareTask(int taskId, int userId);
        Task<List<UserManagerTaskResponse>> GetAllUserTasksForManagerByUserId(int managerId);
        Task<List<TaskStatistics>> GetAllStatisticsByUserId(int managerId);
    }
}
