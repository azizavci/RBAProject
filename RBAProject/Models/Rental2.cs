using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RBAProject.Models
{
    public class Rental2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        public string UserName { get; set; }
        public decimal Carid { get; set; }
        public DateTime Rentdate { get; set; }
        public DateTime Returndate { get; set; }
        public decimal Totalprice { get; set; }
        public String Delivery { get; set; }

        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
