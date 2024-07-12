namespace Core.Models.Auth
{
    public class RegisterResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; } 
    }
}
