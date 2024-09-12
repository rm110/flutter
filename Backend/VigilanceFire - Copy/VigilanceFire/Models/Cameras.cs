using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VigilanceFire.Models
{
    [Table("Cameras")]
    public class Cameras
    {
        [Key]
        [Required]
        public int Cam_Id { get; set; }
        [Required]
        public string location { get; set; }
        [Required]
        public DateTime time{ get; set; }
        [Required]
        public bool status { get; set; }

    }
}
