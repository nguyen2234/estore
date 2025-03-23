using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblDealOfTheWeek
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Images { get; set; }

    public virtual TblProduct? Product { get; set; }
}
