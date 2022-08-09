using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    public class OrderDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        public decimal Total { get; set; }
        [Required]
        public PaymentDetails Payment { get; set; }
        public DateTime CreatedTime { get; set; }
        public string ShippingAddress { get; set; }

    }
}
