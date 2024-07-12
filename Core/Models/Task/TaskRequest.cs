namespace Core.Models.Task
{
    public class TaskRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriorityId { get; set; }
    }
}
