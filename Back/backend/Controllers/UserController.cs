using backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using backend.Models.Entities;

namespace backend.Controllers
{
    [ApiController, Route("/user")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        [HttpGet("{id:long}")]
        public User GetUserById(long id)
        {
            return _userRepository.GetUserById(id);
        }

        [HttpDelete]
        public void DeleteUserById(long id)
        {
            _userRepository.DeleteUserById(id);
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            _userRepository.AddUser(user);
            return Ok(200);
        }

        [HttpPut("{id:long}")]
        public void UpdateUserById(long id)
        {
            _userRepository.UpdateUserById(id);
        }
    }
}
