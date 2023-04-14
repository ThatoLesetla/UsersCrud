using backend.DTOs;
using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(Guid id);
        void CreateUser(User User);
        void DeleteUser(User User);
    }
}
