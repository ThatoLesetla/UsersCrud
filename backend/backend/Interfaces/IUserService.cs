using backend.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAllUsers(bool trackChanges);
        UserDTO GetUser(Guid id, bool trackChanges);
        UserDTO CreateUser(UserDTO User, bool trackChanges);
        void DeleteUser(Guid id, bool trackChanges);
    }
}
