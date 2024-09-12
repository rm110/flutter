using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VigilanceFire.Models
{
    [Table("Evacuation_Instructions")]
    public class Evacuation_Instructions
    {
        [Key]
        public int evacuation_Id { get; set; }

        [Required]
        public string instruction_text { get; set; } 

        [Required]
        [NotMapped]
        public DateTime Time { get; set; }  

        [Required]
        [NotMapped]
        public string Location { get; set; } 
    }
}
