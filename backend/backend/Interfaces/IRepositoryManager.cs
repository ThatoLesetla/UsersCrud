using System;
namespace backend.Interfaces
{
	public interface IRepositoryManager
	{
		IStudentRepository Student { get; }
		IUserRepository User { get; }
		Task SaveAsync();
		void Save();
	}
}

