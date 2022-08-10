using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace backend.Models.Entities
{
    [Table("Users")]
    public class User
    {
        public User(string? userName1, string securityStamp, string? userName2, string? password)
        {
            UserName1 = userName1;
            SecurityStamp = securityStamp;
            UserName2 = userName2;
            Password = password;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public AdminType Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string? UserName1 { get; }
        public string SecurityStamp { get; }
        public string? UserName2 { get; }
    }
}
