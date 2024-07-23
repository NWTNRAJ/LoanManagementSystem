using Company.LoanManagement.Domain.Entities;
using System.Data;

namespace Company.LoanManagement.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        long InsertCustomer(Customer customer);
        DataTable SelectAll();
        long UpdateCustomer(Customer customer);
        long DeleteCustomer(Customer customer);
    }
}
