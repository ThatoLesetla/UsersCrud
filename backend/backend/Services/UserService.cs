using AutoMapper;
using backend.DTOs;
using backend.Interfaces;
using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        private readonly ILoggerManager loggerManager;

        public UserService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager loggerManager)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.loggerManager = loggerManager;
        }
        public UserDTO CreateUser(UserDTO user, bool trackChanges)
        {
            var userEntity = mapper.Map<User>(user);

            repositoryManager.User.CreateUser(userEntity);

            return user;
        }

        public void DeleteUser(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAllUsers(bool trackChanges)
        {
            var users = repositoryManager.User.GetAllUsers();

            var usersDTO = mapper.Map<IEnumerable<UserDTO>>(users);

            return usersDTO;
        }

        public UserDTO GetUser(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
