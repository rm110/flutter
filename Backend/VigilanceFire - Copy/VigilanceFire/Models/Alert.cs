using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VigilanceFire.Models
{
    [Table("Alert")]
    public class Alert
    {
        [Key ,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int alert_Id { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public string location { get; set; }  
        [Required]
        public DateTime time { get; set; } 
        [Required]
        public bool condition { get; set; }  
    }
}
