using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    public class CartItem
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Product Product { get; set; }
        public int  Quantity { get; set; }
        [Required]
        public Cart ShoppingSession { get; set; }
        
        public TimestampAttribute Date { get; set; }



    }
}
