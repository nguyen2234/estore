using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estore.Models
{
    [Table("Catagories")]
    public class Catagori
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }   
        public bool? IsActive { get; set; }
        public int Monney { get; set; }

    }
}
