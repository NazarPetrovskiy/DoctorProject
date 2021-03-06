using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.Model
{
    [Table("TableDataDisease")]
    public class Disease
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string NameDesease { get; set; }
        [Required, StringLength(255)]
        public string Description { get; set; }
    }
}
