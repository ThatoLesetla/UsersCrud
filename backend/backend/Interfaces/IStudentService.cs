using System;
using backend.DTOs;

namespace backend.Interfaces
{
	public interface IStudentService
	{
        IEnumerable<StudentDTO> GetAllStudents(bool trackChanges);
        StudentDTO GetStudent(Guid id, bool trackChanges);
        StudentDTO CreateStudent(StudentDTO student, bool trackChanges);
        void DeleteStudent(Guid id, bool trackChanges);
    }
}

