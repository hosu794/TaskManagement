using Core.Models.Task;

namespace TaskManagement.Core.Models.Manager
{
    public class UserManagerTaskResponse : TaskResponse
    {
        public int UserId {  get; set; }
        public string Username { get; set; }
    }
}
