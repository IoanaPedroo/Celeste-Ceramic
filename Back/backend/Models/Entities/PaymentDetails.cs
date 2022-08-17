using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("PaymentsDetails")]
    public class PaymentDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int Id { get; set; } 
        public decimal Amount { get; set; }
        public string Provider {  get; set; }
        public string Status { get; set; }  

    }
}
