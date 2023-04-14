using backend.DTOs;
using backend.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public UsersController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllUser()
        {
            try
            {
                var User = serviceManager.UserService.GetAllUsers(trackChanges: false);

                return Ok(User);
            }
            catch (Exception ex)    
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAllUser(Guid id)
        {
            try
            {
                var User = serviceManager.UserService.GetUser(id, trackChanges: false);

                return Ok(User);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost(Name = "CreateUser")]
        public IActionResult CreateUser([FromBody] UserDTO User)
        {
            if (User is null)
            {
                return BadRequest("User creation object is null");
            }

            var UserToReturn = serviceManager.UserService.CreateUser(User, trackChanges: false);

            return CreatedAtRoute("CreateUser", new { id = UserToReturn.Id }, UserToReturn);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteUser(Guid id)
        {
            serviceManager.UserService.DeleteUser(id, trackChanges: false);

            return NoContent();
        }
    }
}
