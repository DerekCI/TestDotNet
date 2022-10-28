using Test.Models;

namespace Test.Services
{
    public interface IUserServices
    {
        User GetUser(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
