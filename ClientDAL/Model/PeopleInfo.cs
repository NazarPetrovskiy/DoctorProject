using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.Model
{
    [Table("TableDataPeopleInfo")]
    public class PeopleInfo : BaseEntity<int>
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(60)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
