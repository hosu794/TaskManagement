using Core.Implementations.Task;
using Core.Interfaces.Priority;
using Core.Models.Task;

namespace Core.Interfaces.Task
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IPriorityRepository _priorityRepository;

        public TaskService(ITaskRepository taskRepository, IPriorityRepository priorityRepository)
        {
            _taskRepository = taskRepository;
            _priorityRepository = priorityRepository;
        }

        public async Task<TaskResponse> CreateTask(TaskRequest request, int userId)
        {
            if (!await _priorityRepository.IsPriorityExistsById(userId)) throw new Exception("Prority not exists!");

            return await _taskRepository.CreateTask(new TaskRepositoryDto { UserId = userId, Name = request.Name, Description = request.Description, PriorityId = request.PriorityId });   
        }

        public async Task<bool> DeleteTaskById(int taskId, int userId)
        {
            return await _taskRepository.DeleteTask(taskId, userId);
        }

        public Task<List<TaskResponse>> GetSharedTaskByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskResponse>> GetTaskByUserId(int userId)
        {
            return await _taskRepository.GetTaskByUserId(userId);
        }

        public async Task<TaskResponse> UpdateTask(TaskRequest request, int taskId)
        {
            return await _taskRepository.UpdateTask(new TaskRepositoryDto()
            {
                Description = request.Description,
                Name = request.Name,
                PriorityId = request.PriorityId,    
            }, taskId);
        }
    }
}
