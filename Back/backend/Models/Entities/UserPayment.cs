using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    public class UserPayment
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }

        [Column("PaymentType", TypeName = "varchar")]
        public string PaymentType { get; set; }
        public int AccountNumber { get; set; } 
        public DateOnly Expiry { get; set; }


    }
}
