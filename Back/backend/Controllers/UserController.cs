using backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using backend.Models.Entities;
using Microsoft.AspNetCore.Cors;

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
        [EnableCors("Policy")]

        public JsonResult GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Json(users);
        }
        [HttpGet("{id:long}")]
        public JsonResult GetUserById(long id)
        {
            var user = _userRepository.GetUserById(id);
            return Json(user);
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
        public void UpdateUserById(long id, User user)
        {
            _userRepository.UpdateUserById(id, user);
        }
    }
}
