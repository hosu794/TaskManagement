using Core.Models.Task;
using TaskManagement.Core.Models.Manager;

namespace Core.Implementations.Task
{
    public interface ITaskService
    {
        Task<TaskResponse> CreateTask(TaskRequest request, int userId);
        Task<List<TaskResponse>> GetTaskByUserId(int userId);
        Task<bool> DeleteTaskById(int taskId, int userId);
        Task<TaskResponse> UpdateTask(TaskRequest request, int taskId);
        Task<List<TaskResponse>> GetSharedTaskByUserId(int userId);
        Task<List<TaskResponse>> GetSharedTaskForUserId(int userId);
        Task<TaskResponse> ShareTask(int taskId, int userId);
        Task<List<UserManagerTaskResponse>> GetUserManagerTasks(int managerId);
        Task<List<TaskStatistics>> GetTaskStatisticsByUserId(int userId);
    }
}
