namespace Core.Models.Task
{
    public class TaskRepositoryDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriorityId { get; set; }
    }
}
