using System;
using System.Collections.Generic;

namespace estore.Models;

public partial class TblProduct
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Tittle { get; set; }

    public string? Contents { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public int? Stock { get; set; }

    public string? Images { get; set; }

    public string? Link { get; set; }

    public virtual TblCategory? Category { get; set; }

    public virtual ICollection<TblBanner> TblBanners { get; set; } = new List<TblBanner>();

    public virtual ICollection<TblBenefit> TblBenefits { get; set; } = new List<TblBenefit>();

    public virtual ICollection<TblDealOfTheWeek> TblDealOfTheWeeks { get; set; } = new List<TblDealOfTheWeek>();

    public virtual ICollection<TblNewArrival> TblNewArrivals { get; set; } = new List<TblNewArrival>();

    public virtual ICollection<TblProductDetail> TblProductDetails { get; set; } = new List<TblProductDetail>();

    public virtual ICollection<TblProductSize> TblProductSizes { get; set; } = new List<TblProductSize>();

    public virtual ICollection<TblSlide> TblSlides { get; set; } = new List<TblSlide>();
}
