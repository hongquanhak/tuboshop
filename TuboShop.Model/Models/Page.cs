using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuboShop.Model.Abstract;

namespace TuboShop.Model.Models
{
    [Table("Pages")]
    class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName="varchar")] //tro dung kieu du lieu
        public string Alias { set; get; }

        public string Content { set; get; }
    }
}
