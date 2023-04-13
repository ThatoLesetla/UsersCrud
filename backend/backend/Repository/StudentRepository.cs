using System;
using backend.Data;
using backend.Interfaces;
using backend.Models;

namespace backend.Repository
{
	public class StudentRepository : RepositoryBase<Student>, IStudentRepository
	{
		public StudentRepository(DataContext dataContext) : base(dataContext)
		{
		}

        public void CreateStudent(Student student)
        {
            Create(student);
        }

        public void DeleteStudent(Student student)
        {
            Delete(student);
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges)
        {
            return FindAll(trackChanges).ToList().OrderBy(a => a.FirstName);
        }

        public Student GetStudent(Guid id, bool trackChanges)
        {
            return FindByCondition(a => a.Id.Equals(id), trackChanges).SingleOrDefault();
        }
    }
}

