using Core.Interfaces.Priority;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriorityController : ControllerBase
    {
        private readonly IPriorityService _priorityService;

        public PriorityController(IPriorityService priorityService)
        {
            _priorityService = priorityService;
        }

        [HttpGet("priorities")]
        public async Task<IActionResult> GetPrioties()
        {

            return Ok(await _priorityService.GetPriorities());
        }
    }
}
