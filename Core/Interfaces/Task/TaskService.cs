using Core.Implementations.Task;
using Core.Interfaces.Priority;
using Core.Models.Task;
using TaskManagement.Core.Models.Manager;

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
            if (!await _priorityRepository.IsPriorityExistsById(request.PriorityId)) throw new Exception("Prority not exists!");

            return await _taskRepository.CreateTask(new TaskRepositoryDto { UserId = userId, Name = request.Name, Description = request.Description, PriorityId = request.PriorityId });   
        }

        public async Task<bool> DeleteTaskById(int taskId, int userId)
        {
            return await _taskRepository.DeleteTask(taskId, userId);
        }

        public async Task<List<TaskResponse>> GetSharedTaskByUserId(int userId)
        {
            return await _taskRepository.GetTaskSharedByUser(userId);
        }

        public async Task<List<TaskResponse>> GetSharedTaskForUserId(int userId)
        {
            return await _taskRepository.GetTaskSharedForUser(userId);
        }

        public async Task<List<TaskResponse>> GetTaskByUserId(int userId)
        {
            return await _taskRepository.GetTaskByUserId(userId);
        }

        public async Task<List<TaskStatistics>> GetTaskStatisticsByUserId(int userId)
        {
            return await _taskRepository.GetAllStatisticsByUserId(userId);
        }

        public async Task<List<UserManagerTaskResponse>> GetUserManagerTasks(int managerId)
        {
            return await _taskRepository.GetAllUserTasksForManagerByUserId(managerId);
        }

        public async Task<TaskResponse> ShareTask(int taskId, int userId)
        {
            return await _taskRepository.ShareTask(taskId, userId); 
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
