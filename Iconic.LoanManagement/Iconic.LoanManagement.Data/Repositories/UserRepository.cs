using Iconic.LoanManagement.Data.DbContext;
using Iconic.LoanManagement.Domain.Entities;
using Iconic.LoanManagement.Domain.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace Iconic.LoanManagement.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public long InsertUser(Users users)
        {
            Dictionary<string, object> insertParameters = new Dictionary<string, object>()
            {
               {"@Username", users.UserName },
               {"@PasswordHash", users.PasswordHash},
               {"@UserRole", users.UserRole }
            };
            return AppDbContext.Insert("uspInsertUser", insertParameters);
        }
        public DataTable SelectAllUser()
        {
            return AppDbContext.Select("uspGetUsers");
        }
        public long UpdateUser(Users users)
        {
            Dictionary<string, object> updateParameters = new Dictionary<string, object>()
            {
                {"@ID", users.UserID },
                {"@Username", users.UserName },
                {"@PasswordHash", users.PasswordHash},
                {"@UserRole", users.UserRole }
            };
            return AppDbContext.Update("uspUpdateUser", updateParameters);
        }
    }
}
