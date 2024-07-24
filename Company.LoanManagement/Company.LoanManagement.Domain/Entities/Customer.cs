namespace Company.LoanManagement.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string Email { get; set; } = string.Empty!;
    }
}
