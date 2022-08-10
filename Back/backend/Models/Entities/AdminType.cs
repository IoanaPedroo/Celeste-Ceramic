using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.Entities
{
    [Table("AdminTypes")]
    public class AdminType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public List<string> Type { get; set; }
        [Required]
        public string Permissions { get; set; } 
  

    }
}
