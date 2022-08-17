using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("CartItems")]
    public class CartItem
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int  Quantity { get; set; }
        [Required]
        public Cart Cart { get; set; }
        [Required]
        public DateTime Date { get; set; }



    }
}
