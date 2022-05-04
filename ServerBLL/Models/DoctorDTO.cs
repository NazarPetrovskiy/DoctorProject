using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Models
{
    public class DoctorDTO
    {
        public int ID { get; set; }
        public string Specialty { get; set; }
        public PeopleInfoDTO InfoPeople { get; set; }
    }
}