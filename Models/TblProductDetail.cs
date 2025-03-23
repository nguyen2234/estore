using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblProductDetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? SizeId { get; set; }

    public string? Material { get; set; }

    public string? Brand { get; set; }

    public string? Color { get; set; }

    public string? Quantity { get; set; }

    public virtual TblProduct? Product { get; set; }

    public virtual TblProductSize? Size { get; set; }
}
