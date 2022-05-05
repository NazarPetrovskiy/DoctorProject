using System.ComponentModel.DataAnnotations;

namespace ClientBLL.ClientModels
{
    class Disease
    {

        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
