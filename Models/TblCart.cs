using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblCart
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public int? SizeId { get; set; }

    public virtual TblProductSize? Size { get; set; }

    public virtual TblUser? User { get; set; }
}
