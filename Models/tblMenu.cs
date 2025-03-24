using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace estore.Models;

public partial class TblMenu
{
    [Key]
    public int MenuId { get; set; }

    public string? MenuName { get; set; }

    public string? Alias { get; set; }

    public string? Icon { get; set; }

    public int? CategoryId { get; set; }

    public int ParentId { get; set; }

    public string? Posion { get; set; }

    public bool? IsActive { get; set; }
    public int Levels { get; set; }
    public int MenuOrder { get; set; }
    

    //public virtual TblCategory? Category { get; set; }
}
