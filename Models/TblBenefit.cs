using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblBenefit
{
    public int Id { get; set; }

    public string? Titile { get; set; }

    public string? Contents { get; set; }

    public string? Icon { get; set; }

    public int? ProductId { get; set; }

    public int? CategoryId { get; set; }

    public virtual TblCategory? Category { get; set; }

    public virtual TblProduct? Product { get; set; }
}
