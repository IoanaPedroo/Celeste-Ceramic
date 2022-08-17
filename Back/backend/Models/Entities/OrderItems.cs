using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("OrdersItems")]
    public class OrderItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int Id { get; set; }
        public OrderDetails OrderDetails { get; set; }  
        public Product Product { get; set; }
        public int Quantity { get; set; }   

    }
}
