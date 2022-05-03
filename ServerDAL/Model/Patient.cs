using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.Model
{
    [Table("TableDataPatient")]
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public PeopleInfo InfoPeople { get; set; }
        public Doctor Likar { get; set; }
        public virtual IList<Disease> Diseases { get; set; }
        public virtual IList<Analysis> Analyses { get; set; }
    }
}
