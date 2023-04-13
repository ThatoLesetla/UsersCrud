using System;
using backend.Models;

namespace backend.Interfaces
{
	public interface IStudentRepository
	{
        IEnumerable<Student> GetAllStudents(bool trackChanges);
        Student GetStudent(Guid id, bool trackChanges);
        void CreateStudent(Student Student);
        void DeleteStudent(Student Student);
    }
}

