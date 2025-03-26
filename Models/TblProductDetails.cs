using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estore.Models
{
    [Table("tblProductDetails")]
    public class TblProductDetails
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public string? Metarial { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public string? Quantity { get; set; }
    }
}
