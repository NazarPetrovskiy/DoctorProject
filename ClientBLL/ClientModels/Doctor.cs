using System.ComponentModel.DataAnnotations;


namespace ClientBLL.ClientModels
{
    class Doctor
    {

        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string Specialty { get; set; }

        public People InfoPeople { get; set; }
    }
}
