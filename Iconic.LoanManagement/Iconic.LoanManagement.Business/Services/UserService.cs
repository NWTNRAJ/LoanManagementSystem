using Iconic.LoanManagement.Business.Interfaces;
using Iconic.LoanManagement.Domain.Entities;
using Iconic.LoanManagement.Domain.Interfaces;
using Microsoft.AspNet.Identity;
using System.Data;

namespace Iconic.LoanManagement.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher _passwordHasher;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _passwordHasher = new PasswordHasher();
        }

        public long InsertUser(Users users)
        {
            // Hash the password before saving
            users.PasswordHash = _passwordHasher.HashPassword(users.PasswordHash);

            return _userRepository.InsertUser(users);
        }
        public DataTable SelectAllUser()
        {
            return _userRepository.SelectAllUser();
        }
        public long UpdateUser(Users users)
        {
            // Hash the password if it's updated
            if (!string.IsNullOrEmpty(users.PasswordHash))
            {
                users.PasswordHash = _passwordHasher.HashPassword(users.PasswordHash);
            }
            return _userRepository.UpdateUser(users);
        }
    }
}
