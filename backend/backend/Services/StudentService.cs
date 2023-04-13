using System;
using AutoMapper;
using backend.DTOs;
using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
	public class StudentService : IStudentService
	{
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        private readonly ILoggerManager loggerManager;

		public StudentService(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager loggerManager)
		{
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.loggerManager = loggerManager;
		}

        public StudentDTO CreateStudent(StudentDTO student, bool trackChanges)
        {
            var studentEntity = mapper.Map<Student>(student);

            repositoryManager.Student.CreateStudent(studentEntity);
            repositoryManager.Save();

            var studentToReturn = mapper.Map<StudentDTO>(studentEntity);

            return studentToReturn;
        }

        public void DeleteStudent(Guid id, bool trackChanges)
        {
            var student = repositoryManager.Student.GetStudent(id, trackChanges);

            if (student is null) {
                loggerManager.LogInfo($"Student not found on database records for student ID: {id.ToString()}");
                throw new Exception($"Student not on found on database records");
            }

            repositoryManager.Student.DeleteStudent(student);
            repositoryManager.Save(); 
        }

        public IEnumerable<StudentDTO> GetAllStudents(bool trackChanges)
        {
            var students = repositoryManager.Student.GetAllStudents(trackChanges);

            var studentsDTO = mapper.Map<IEnumerable<StudentDTO>>(students);

            return studentsDTO;
        }

        public StudentDTO GetStudent(Guid id, bool trackChanges)
        {
            var student = repositoryManager.Student.GetStudent(id, trackChanges);
            var studentDTO = mapper.Map<StudentDTO>(student);

            return studentDTO;
        }
    }
}

