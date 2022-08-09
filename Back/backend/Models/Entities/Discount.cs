using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("Discounts")]
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [MinLength(10), MaxLength(25)]
        public string? Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [Required]
        public int DiscountPercent { get; set; }
        [Required]
        public Boolean IsActive { get; set; }   
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }   
        public DateTime Deleted { get; set; }

    }
}
