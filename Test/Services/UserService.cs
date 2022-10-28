using Test.Models;

namespace Test.Services
{
    public class UserService : IUserServices
    {
        private static List<User> _users = new List<User>();
       

        public void DeleteUser(int id)
        {
            _users.RemoveAt(id);
        }

        public User GetUser(int id)
        {
            return _users[id];
        }

        public void UpdateUser(User userToUpdate)
        {
            User userUpdated = new User();
            foreach (User user in _users)
            {
                if (user.UserId == userToUpdate.UserId)
                {
                    user.Name = userToUpdate.Name;
                    user.email = userToUpdate.email;
                    user.phone = userToUpdate.phone;
                    userUpdated = user;
                }
            }
        }

       /* void AddUser(User user)
        {
            user.UserId = _users.Count + 1;
            _users.Add(user);
        }*/

        void IUserServices.AddUser(User user)
        {
            user.UserId = _users.Count + 1;
            _users.Add(user);
        }
    }
}
