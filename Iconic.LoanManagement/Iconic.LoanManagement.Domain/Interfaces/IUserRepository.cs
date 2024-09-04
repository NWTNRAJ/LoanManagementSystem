using Iconic.LoanManagement.Domain.Entities;
using System.Data;

namespace Iconic.LoanManagement.Domain.Interfaces
{
    public interface IUserRepository
    {
        long InsertUser(Users users);
        DataTable SelectAllUser();
        long UpdateUser(Users users);
    }
}
