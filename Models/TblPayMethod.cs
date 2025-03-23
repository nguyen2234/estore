using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblPayMethod
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();
}
