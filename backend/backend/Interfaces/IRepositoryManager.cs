using System;
namespace backend.Interfaces
{
	public interface IRepositoryManager
	{
		IStudentRepository Student { get; }
		Task SaveAsync();
		void Save();
	}
}

