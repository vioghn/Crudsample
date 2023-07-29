using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFcodefirstApp.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Reflection.Metadata.Ecma335;

namespace EFcodefirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext userContext;

        public UsersController(UserContext userContext)
        {
            this.userContext = userContext; 
        }
        [HttpGet]
        [Route("GetUsers")]
        public List<users> GetUsers()
        {
            return userContext.users.ToList();
        }
        [HttpGet]
        [Route("GetUser")]
        
        public users GetUser(int id)
        {
            return userContext.users.Where(x => x.ID == id).FirstOrDefault();
        }
        [HttpPost]
        [Route("AddUser")]
        public string AddUser(users users)
        {
            string response = string.Empty;
            userContext.users.Add(users);
            userContext.SaveChanges();
            return "user added"; 
        }
        [HttpPut]
        [Route("UpdateUser")]
        public string UpdateUser(users user)
        {
            userContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userContext.SaveChanges();
            return "User Updated"; 

        }
        [HttpDelete]
        [Route("DeleteUser")]
        public string DeleteUser(users user)
        {
            userContext.users.Remove(user);
            userContext.SaveChanges();
            return "user deleted";

        }


    }
}
