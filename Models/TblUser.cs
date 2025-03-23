using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblUser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? ImgUser { get; set; }

    public bool? IsActive { get; set; }

    public string? Role { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<TblCart> TblCarts { get; set; } = new List<TblCart>();

    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();
}
