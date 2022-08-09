using backend.Models.Entities;

namespace backend.Models.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(long id);
        void DeleteUserById(long id);
        void AddUser(User user);
        void UpdateUserById(long id);
    }
}
