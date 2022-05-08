using ClientBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Models
{
    public class DoctorDTO
    {
        public int Id { get; set; }
        public string Specialty { get; set; }
        public PeopleInfoDTO InfoPeople { get; set; }
    }
}