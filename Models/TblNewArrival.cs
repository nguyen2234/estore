using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblNewArrival
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Contents { get; set; }

    public string? Imange { get; set; }

    public string? Price { get; set; }

    public int? ProductId { get; set; }

    public virtual TblProduct? Product { get; set; }
}
