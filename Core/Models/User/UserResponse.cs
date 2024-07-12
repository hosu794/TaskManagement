namespace TaskManagement.Core.Models.User
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsManager { get; set; } = false;
    }
}
