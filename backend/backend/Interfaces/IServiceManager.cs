using System;
namespace backend.Interfaces
{
	public interface IServiceManager
	{
		IStudentService StudentService { get; }
	}
}

