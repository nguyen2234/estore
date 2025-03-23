using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblBanner
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Images { get; set; }

    public int? CategoryId { get; set; }

    public int? ProductId { get; set; }

    public string? Link { get; set; }

    public virtual TblCategory? Category { get; set; }

    public virtual TblProduct? Product { get; set; }
}
