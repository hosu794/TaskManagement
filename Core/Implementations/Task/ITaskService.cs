using Core.Models.Task;

namespace Core.Implementations.Task
{
    public interface ITaskService
    {
        public Task<TaskResponse> CreateTask(TaskRequest request, int userId);
        public Task<List<TaskResponse>> GetTaskByUserId(int userId);
        public Task<bool> DeleteTaskById(int taskId, int userId);
        public Task<TaskResponse> UpdateTask(TaskRequest request, int taskId);
        public Task<List<TaskResponse>> GetSharedTaskByUserId(int userId);
        public Task<List<TaskResponse>> GetSharedTaskForUserId(int userId);
        public Task<TaskResponse> ShareTask(int taskId, int userId);    
    }
}
