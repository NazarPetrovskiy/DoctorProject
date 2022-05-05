using System.ComponentModel.DataAnnotations;


namespace ClientBLL.ClientModels
{
    class People
    {

        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
