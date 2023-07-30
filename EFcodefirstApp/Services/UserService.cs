using AspnetCoreCRUDApp.Contracts;
using EFcodefirstApp.Models;

namespace AspnetCoreCRUDApp.Services
{
    public class UserService : IUserService
    {
        private readonly UserContext userContext;

        public UserService(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public List<users> GetUsers()
        {
            return userContext.users.ToList();
        }

        public users GetUser(int id)
        {
            return userContext.users.FirstOrDefault(x => x.ID == id);
        }

        public string AddUser(users user)
        {
            userContext.users.Add(user);
            userContext.SaveChanges();
            return "User added";
        }

        public string UpdateUser(users user)
        {
            userContext.users.Update(user);
            userContext.SaveChanges();
            return "User updated";
        }

        public string DeleteUser(users user)
        {
            userContext.users.Remove(user);
            userContext.SaveChanges();
            return "User deleted";
        }
    }
}