using Sprint3.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sprint3.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
  