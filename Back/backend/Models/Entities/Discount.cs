using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; } 
        public int DiscountPercent { get; set; } = 0;
        public Boolean IsActive { get; set; }   
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }   
        public DateTime Deleted { get; set; }

    }
}
