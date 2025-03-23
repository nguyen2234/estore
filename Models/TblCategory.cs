using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<TblBanner> TblBanners { get; set; } = new List<TblBanner>();

    public virtual ICollection<TblBenefit> TblBenefits { get; set; } = new List<TblBenefit>();

    public virtual ICollection<TblMenu> TblMenus { get; set; } = new List<TblMenu>();

    public virtual ICollection<TblProduct> TblProducts { get; set; } = new List<TblProduct>();

    public virtual ICollection<TblSlide> TblSlides { get; set; } = new List<TblSlide>();
}
