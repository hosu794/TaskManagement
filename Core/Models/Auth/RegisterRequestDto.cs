namespace Core.Models.Auth
{
    public class RegisterRequestDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; } 
    }
}
