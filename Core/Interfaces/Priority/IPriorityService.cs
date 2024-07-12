using Core.Models.Priority;

namespace Core.Interfaces.Priority
{
    public interface IPriorityService
    {
        Task<List<PriorityResponse>> GetPriorities();
    }
}
