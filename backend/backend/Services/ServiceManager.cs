using System;
using AutoMapper;
using backend.Interfaces;

namespace backend.Services
{
	public class ServiceManager : IServiceManager
	{
		private Lazy<IStudentService> studentService;
		private Lazy<IUserService> userService;

		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager loggerManager)
		{
			studentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager, mapper, loggerManager));
			userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper, loggerManager));
		}

		public IStudentService StudentService => studentService.Value;

		public IUserService UserService => userService.Value;
    }
}

