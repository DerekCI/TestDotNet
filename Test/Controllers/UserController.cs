using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            _userService = userService;
        }

        [HttpPost("user/add")]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return Ok("");
        }
        [HttpGet("user/get")]
        public IActionResult GetUser(int id)
        {
            return Ok(_userService.GetUser(id));
        }
        [HttpPut("user/update")]
        public IActionResult UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("user/delete")]
        public IActionResult DeleteUser(int id)
        {
            var existingItem = _userService.GetUser(id);
            if (existingItem is null)
            {
                return NotFound();
            }
            _userService.DeleteUser(id);
            return NoContent();
        }

    }
}
