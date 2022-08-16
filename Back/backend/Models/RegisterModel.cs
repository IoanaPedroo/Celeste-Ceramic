using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class RegisterModel
    {
        public RegisterModel(string? email, string? username, string? password)
        {
            Email = email;
            Username = username;
            Password = password;
        }

        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
