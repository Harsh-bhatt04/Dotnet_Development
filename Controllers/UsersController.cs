using Microsoft.AspNetCore.Mvc;
using MyfirstApp.services.Intersface;

namespace MyfirstApp.Controllers
{
    [ApiController]
    [Route("api/users")]

    public class UsersController : ControllerBase
    {
        private readonly IUserService _userServices;

        public UsersController(IUserService userService)
        {
            _userServices = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userServices.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userServices.GetUserById(id);

            if(user == null)
                return NotFound("User not found");
            return Ok(user);
        }
    }
}