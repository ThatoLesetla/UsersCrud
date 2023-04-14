using backend.Data;
using backend.Interfaces;
using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public void CreateUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            SaveUserToXML(user);
        }

        public void DeleteUser(User User)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return LoadUsersFromXML();
        }

        public User GetUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
