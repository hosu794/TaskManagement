using Core.Models.Task;
using Data.DbModels;

namespace Core.Implementations.Task
{
    public interface ITaskRepository
    {
        Task<TaskTodo> CreateTask(TaskRepositoryDto task);
    }
}
