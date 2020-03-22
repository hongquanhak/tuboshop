using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuboShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key] //khoa chinh
        [MaxLength(50)] //do dai kieu du lieu
        public string ID { set; get; }

        [Required] //yeu cau
        public string Content { set; get; }
    }
}