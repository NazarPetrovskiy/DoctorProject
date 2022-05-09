using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.Model
{
    [Table("TableDataDoctor")]
    public class Doctor : BaseEntity<int>
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(60)]
        public string Specialty { get; set; }
        public PeopleInfo InfoPeople { get; set; }
    }
}
