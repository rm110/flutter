using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VigilanceFire.Models
{
    [Table("Administrator")]
    public class Administrator
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int admin_Id { get; set; }
        [Required]
        public string name { get; set; }

        public virtual List<User> users { get; set; }
    }
}
