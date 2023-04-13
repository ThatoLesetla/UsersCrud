using System;
using backend.DTOs;
using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
        private readonly IServiceManager serviceManager;

        public StudentController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            try
            {
                var Student = serviceManager.StudentService.GetAllStudents(trackChanges: false);

                return Ok(Student);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAllStudent(Guid id)
        {
            try
            {
                var Student = serviceManager.StudentService.GetStudent(id, trackChanges: false);

                return Ok(Student);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] StudentDTO student)
        {
            if (student is null)
            {
                return BadRequest("Student creation object is null");
            }

            var studentToReturn = serviceManager.StudentService.CreateStudent(student, trackChanges: false);

            return CreatedAtRoute("CreateStudent", new { id = studentToReturn.Id }, studentToReturn);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteStudent(Guid id)
        {
            serviceManager.StudentService.DeleteStudent(id, trackChanges: false);

            return NoContent();
        }
    }
}

