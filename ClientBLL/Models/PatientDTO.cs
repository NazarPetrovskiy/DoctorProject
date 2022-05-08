using ClientBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Models
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public PeopleInfoDTO InfoPeople { get; set; }
        public DoctorDTO HealingDoctor { get; set; }
        public virtual IList<DiseaseDTO> Diseases { get; set; }
        public virtual IList<AnalysisDTO> Analyses { get; set; }
    }
}