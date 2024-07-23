using Company.LoanManagement.Data.Context;
using Company.LoanManagement.Data.Parameters;
using Company.LoanManagement.Data.StoredProcedures;
using Company.LoanManagement.Domain.Entities;
using Company.LoanManagement.Domain.Interfaces;
using System.Data;

namespace Company.LoanManagement.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public long InsertCustomer(Customer customer)
        {
            Dictionary<string, object> insertParameters = new Dictionary<string, object>()
            {
                { CustomerParameter.CustomerName, customer.CustomerName },
                { CustomerParameter.Address, customer.Address },
                { CustomerParameter.ContactNumber, customer.ContactNumber },
                { CustomerParameter.Email, customer.Email },
            };
            return AppDbContext.Insert(Insert.InsertCustomer, insertParameters);
        }
        public DataTable SelectAll()
        {
            return AppDbContext.Select(Select.GetCustomer);
        }
        public long UpdateCustomer(Customer customer)
        {
            Dictionary<string, object> updateParameters = new Dictionary<string, object>()
            {
                { CustomerParameter.Id, customer.Id },
                { CustomerParameter.CustomerName, customer.CustomerName },
                { CustomerParameter.Address, customer.Address },
                { CustomerParameter.ContactNumber, customer.ContactNumber },
                { CustomerParameter.Email, customer.Email },
            };
            return AppDbContext.Update(Update.UpdateCustomer, updateParameters);
        }
        public long DeleteCustomer(Customer customer)
        {
            Dictionary<string, object> deleteParameters = new Dictionary<string, object>()
            {
                { CustomerParameter.Id, customer.Id }
            };
            return AppDbContext.Delete(Delete.DeleteCustomer, deleteParameters);
        }
    }
}
