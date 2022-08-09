using backend.Models.Entities;
using backend.Models.Interfaces;

namespace backend.Models.Repositories
{
    public class UserRepository :IUserRepository
    {
        private readonly IUserRepository _userRepository;

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserById(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
