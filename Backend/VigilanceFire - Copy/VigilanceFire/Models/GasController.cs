using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VigilanceFire.Models
{
    [Table("GasController")]
    public class GasController
    {
        [Required]
        public int Id { get; set; }
        [NotMapped]
        public float GasQuantity { get; set; }
        [NotMapped]
        public float Temperature { get; set; }
        [NotMapped]
        public float Humidity { get; set; }
        [NotMapped]
        public string History { get; set; }

    }
}
