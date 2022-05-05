using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ClientBLL.ClientModels
{
    class Patient
    {

        [Key]
        public int ID { get; set; }

        public People InfoPeople { get; set; }

        public Doctor HealingDoctor { get; set; }

        public virtual IList<Disease> DiseaseDTOs { get; set; }

        public virtual IList<Analysis> Analyses { get; set; }

    }
}
