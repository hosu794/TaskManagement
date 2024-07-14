using Core.Extensions;
using Core.Implementations.Task;
using Core.Models.Stats;
using Core.Models.Task;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using System.Security.Claims;
using TaskManagement.Core.Models.ShareTask;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("tasks")]
        [Authorize]
        public async Task<IActionResult> CreateTask([FromBody] TaskRequest request)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await _taskService.CreateTask(request, parsedIntUserId));
        }

        [HttpPut("tasks")]
        [Authorize]
        public async Task<IActionResult> UpdateTask([FromBody] TaskRequest request, [FromQuery] int taskId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            var result = await _taskService.UpdateTask(request, taskId);

            return Ok(result);
        }

        [HttpDelete("tasks")]
        [Authorize]
        public async Task<IActionResult> DeleteTask([FromQuery] int taskId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await _taskService.DeleteTaskById(taskId, parsedIntUserId));
        }

        [HttpPost("share/task")]
        [Authorize]
        public async Task<IActionResult> ShareTask([FromBody] ShareTaskRequest request)
        {
            return Ok(await _taskService.ShareTask(request.TaskId, request.UserId));
        }

        [HttpDelete("shared/tasks")]
        [Authorize]
        public async Task<IActionResult> DeleteShareTsk([FromQuery] int taskId, [FromQuery] int userId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("tasks")]
        [Authorize]
        public async Task<IActionResult> GetAllUserTask()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await _taskService.GetTaskByUserId(parsedIntUserId));
        }

        [HttpGet("shared/tasks/by/user")]
        [Authorize]
        public async Task<IActionResult> GetSharedTaskByUser()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await _taskService.GetSharedTaskByUserId(parsedIntUserId));
        }

        [HttpGet("shared/tasks/for/user")]
        public async Task<IActionResult> GetSharedTaskForUser()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            int.TryParse(userId, out int parsedIntUserId);

            return Ok(await _taskService.GetSharedTaskForUserId(parsedIntUserId));
        }

        [HttpGet("tasks/attached")]
        [Authorize]
        [ManagerOnly]
        public async Task<IActionResult> GetAttachedUsetTasks()
        {
            throw new NotImplementedException();
        }

        [HttpGet("tasks/manager/stats")]
        [Authorize]
        [ManagerOnly]
        public async Task<IActionResult> GetStats([FromBody] StatsRequest request) { throw new NotImplementedException(); }

    }
}
