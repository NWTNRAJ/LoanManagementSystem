using Company.LoanManagement.Domain.Entities;
using System.Data;

namespace Company.LoanManagement.Business.Interfaces
{
    public interface ICustomerService
    {
        long InsertCustomer(Customer customer);
        DataTable SelectAll();
        long UpdateCustomer(Customer customer);
        long DeleteCustomer(Customer customer);
    }
}
