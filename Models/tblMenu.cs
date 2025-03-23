using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblMenu
{
    public int MenuId { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public string? Icon { get; set; }

    public int? CategoryId { get; set; }

    public string? ParentId { get; set; }

    public string? Posion { get; set; }

    public bool? IsActive { get; set; }

    public virtual TblCategory? Category { get; set; }
}
