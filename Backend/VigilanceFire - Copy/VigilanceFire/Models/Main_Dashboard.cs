using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VigilanceFire.Models
{
    [Table("Main-Dashboard")]
    public class Main_Dashboard
    {
        [Key]
        public int mainDP_Id { get; set; }
        [Required]
        public string name { get; set; }
        [NotMapped]
        public double Temperature { get; set; } 
        [NotMapped]
        public double GasQuantity { get; set; } 
        [NotMapped]
        public double Performance { get; set; }
        [NotMapped]
        public List<Alert> Alerts { get; set; }
    }
}
