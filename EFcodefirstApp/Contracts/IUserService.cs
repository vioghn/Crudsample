using EFcodefirstApp.Models;

namespace AspnetCoreCRUDApp.Contracts
{
    public interface IUserService
    {
        List<users> GetUsers();
        users GetUser(int id);
        string AddUser(users users);
        string UpdateUser(users user);
        string DeleteUser(users user);
    }
}