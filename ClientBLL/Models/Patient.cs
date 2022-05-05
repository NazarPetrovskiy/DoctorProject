using System.Collections.Generic;

namespace ClientBLL.Models
{
    class Patient
    {

        
        public int ID { get; set; }

        public People InfoPeople { get; set; }

        public Doctor HealingDoctor { get; set; }

        public IList<Disease> Diseases { get; set; }

        public IList<Analysis> Analyses { get; set; }

    }
}
