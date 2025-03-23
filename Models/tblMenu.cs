using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estore.Models
{
    [Table("tblMenu")]
    public class tblMenu
    {
        [Key]
        public  int MenuId { get; set; }
        public string? MenuName { get; set; }
        public  string? Link { get; set; }
        public  string? Icon { get; set; }
        public bool? IsActive { get; set; }
        public int ParentId { get; set; }
        public int MenuOrder { get; set; }
        public int Levels { get; set; }
    }
}