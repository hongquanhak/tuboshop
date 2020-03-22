using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuboShop.Model.Models
{
    [Table("VisitorStatistics")]
    class VisitorStatistic
    {
        [Key]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisitedDate { set; get; }
        [MaxLength(50)]
        public string IPAdrress { set; get; }
    }
}
