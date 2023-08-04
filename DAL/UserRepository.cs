
using BookstoreApi.Models;
using System.Collections.Generic;

namespace BookstoreApi.DAL
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();


        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int userId)
        {
            return _users.Find(u => u.UserId == userId);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

    }
}
