using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Core.Models.Manager
{
    [Keyless]
    public class TaskStatistics
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TaskCount { get; set; }
    }
}
