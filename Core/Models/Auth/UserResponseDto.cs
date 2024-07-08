namespace Core.Models.Auth
{
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; } 
    }
}
