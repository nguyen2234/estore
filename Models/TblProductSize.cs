using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estore.Models
{
    [Table("tblProductSize")]
    public class TblProductSize
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Size { get; set; }
        public string? Quantity { get; set; }
        [ForeignKey("ProductId")]
        public TblProducts? products { get; set; }

    }
}
