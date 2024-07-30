using Company.LoanManagement.Business.Interfaces;
using Company.LoanManagement.Domain.Entities;
using Company.LoanManagement.Domain.Interfaces;
using System.Data;
 
namespace Company.LoanManagement.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public long InsertCustomer(Customer customer)
        {
            return _customerRepository.InsertCustomer(customer);
        }
        public DataTable SelectAll()
        {
            return _customerRepository.SelectAll();
        }
        public long UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
        public long DeleteCustomer(Customer customer)
        {
            return _customerRepository.DeleteCustomer(customer);
        }
    }
}
