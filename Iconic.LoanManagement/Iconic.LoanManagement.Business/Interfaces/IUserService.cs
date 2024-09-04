using Iconic.LoanManagement.Domain.Entities;
using System.Data;

namespace Iconic.LoanManagement.Business.Interfaces
{
    public interface IUserService
    {
        long InsertUser(Users users);
        DataTable SelectAllUser();
        long UpdateUser(Users users);
    }
}
