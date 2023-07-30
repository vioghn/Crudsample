using Microsoft.AspNetCore.Mvc;
using AspnetCoreCRUDApp.Contracts;
using EFcodefirstApp.Models;

namespace EFcodefirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("GetUsers")]
        public ActionResult<List<users>> GetUsers()
        {
            var users = userService.GetUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult<users> GetUser(int id)
        {
            var user = userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        [Route("AddUser")]
        public ActionResult<string> AddUser(users user)
        {
            var response = userService.AddUser(user);
            return Ok(response);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public ActionResult<string> UpdateUser(users user)
        {
            var response = userService.UpdateUser(user);
            return Ok(response);
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public ActionResult<string> DeleteUser(users user)
        {
            var response = userService.DeleteUser(user);
            return Ok(response);
        }
    }
}