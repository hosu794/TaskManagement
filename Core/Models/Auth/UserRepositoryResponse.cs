namespace Core.Models.Auth
{
    public class UserRepositoryResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; } = false;

    }
}
