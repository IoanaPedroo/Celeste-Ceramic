using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("Products")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public int Price { get; set; }
        public string Currency { get; set; } = string.Empty;
        public Discount? Discount { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public ProductInventory ProductInventory { get; set; }

        [Column("ImagePath")]
        public byte[] Image { get; set; }


    }
}
