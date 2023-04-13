using System;
using AutoMapper;
using backend.Interfaces;

namespace backend.Services
{
	public class ServiceManager : IServiceManager
	{
		private Lazy<IStudentService> studentService;

		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager loggerManager)
		{
			studentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager, mapper, loggerManager));
		}

		public IStudentService StudentService => studentService.Value;
    }
}

