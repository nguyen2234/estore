using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblProductSize
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Size { get; set; }

    public string? Quantity { get; set; }

    public virtual TblProduct? Product { get; set; }

    public virtual ICollection<TblCart> TblCarts { get; set; } = new List<TblCart>();

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();
}
