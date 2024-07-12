using Core.Models.Task;

namespace Core.Implementations.Task
{
    public interface ITaskRepository
    {
        Task<TaskResponse> CreateTask(TaskRepositoryDto task);
        Task<bool> DeleteTask(int taskId);
        Task<TaskResponse> UpdateTask(TaskRepositoryDto task, int taskId);
        Task<List<TaskResponse>> GetTaskByUserId(int userId);
        Task<List<TaskResponse>> GetTaskSharedForUser(int userId);
        Task<List<TaskResponse>> GetTaskSharedByUser(int userId);
    }
}
