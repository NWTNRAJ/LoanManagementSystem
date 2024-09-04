namespace Iconic.LoanManagement.Domain.Entities
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; }
        public string UserRole { get; set; }

    }
}
