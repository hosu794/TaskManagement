using Core.Interfaces.Priority;
using Core.Models.Priority;

namespace Core.Implementations.Priority
{
    public class PriorityService : IPriorityService
    {
        private readonly IPriorityRepository _priorityRepository;

        public PriorityService(IPriorityRepository priorityService)
        {
            _priorityRepository = priorityService;
        }

        public async Task<List<PriorityResponse>> GetPriorities()
        {
            return await _priorityRepository.GetPriorities();
        }
    }
}
