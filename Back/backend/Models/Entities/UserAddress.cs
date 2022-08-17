using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("UsersAddress")]
    public class UserAddress
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        public string PrimaryAddress { get; set; } = string.Empty; 
        public string SecondaryAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int  PostalCode { get; set; }
        public string Country { get; set; } = string.Empty;

        

    }
}
