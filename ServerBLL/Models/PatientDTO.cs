using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Models
{
    public class PatientDTO
    {
        public int ID { get; set; }
        public PeopleInfoDTO InfoPeople { get; set; }
        public DoctorDTO HealingDoctor { get; set; }
        public virtual IList<DiseaseDTO> DiseaseDTOs { get; set; }
        public virtual IList<AnalysisDTO> Analyses { get; set; }
    }
}