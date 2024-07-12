using Core.Models.Priority;

namespace Core.Interfaces.Priority
{
    public interface IPriorityRepository
    {
        Task<List<PriorityResponse>> GetPriorities();
    }
}
