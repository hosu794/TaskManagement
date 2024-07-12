using Core.Extensions;
using Core.Models.Stats;
using Core.Models.Task;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase 
    {

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateTask([FromBody] TaskRequest request)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await Task.FromResult(new { parsedIntUserId }));
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateTask([FromBody] TaskRequest request)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            throw new NotImplementedException();
        }

        [HttpDelete]    
        public async Task<IActionResult> DeleteTask([FromQuery] int taskId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> ShareTask([FromQuery] int taskId, [FromQuery] int userId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShareTsk([FromQuery] int taskId, [FromQuery] int userId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserTask()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetSharedTasks()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            throw new NotImplementedException();
        }


        [HttpGet]
        [ManagerOnly]
        public async Task<IActionResult> GetAttachedUsetTasks()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetStats([FromBody] StatsRequest request) {  throw new NotImplementedException(); }

    }
}
