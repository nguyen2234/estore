using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblOrder
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Address { get; set; }

    public string? Quantity { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? PaymethodId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Status { get; set; }

    public virtual TblPayMethod? Paymethod { get; set; }

    public virtual TblUser? User { get; set; }
}
