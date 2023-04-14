using System;
using backend.Data;
using backend.Interfaces;

namespace backend.Repository
{
	public class RepositoryManager : IRepositoryManager
	{
        private readonly DataContext dataContext;
        private readonly Lazy<IStudentRepository> studentRepository;
        private readonly Lazy<IUserRepository> userRepository;

		public RepositoryManager(DataContext dataContext)
		{
            this.dataContext = dataContext;
            studentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(dataContext));
            userRepository = new Lazy<IUserRepository>(() => new UserRepository(dataContext));
		}

        public IStudentRepository Student => studentRepository.Value;

        public IUserRepository User => userRepository.Value;

        public void Save()
        {
            dataContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}

