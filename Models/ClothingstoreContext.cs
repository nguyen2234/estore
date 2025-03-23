using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace estore.Models;

public partial class ClothingstoreContext : DbContext
{
    public ClothingstoreContext()
    {
    }

    public ClothingstoreContext(DbContextOptions<ClothingstoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBanner> TblBanners { get; set; }

    public virtual DbSet<TblBenefit> TblBenefits { get; set; }

    public virtual DbSet<TblCart> TblCarts { get; set; }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblDealOfTheWeek> TblDealOfTheWeeks { get; set; }

    public virtual DbSet<TblFooter> TblFooters { get; set; }

    public virtual DbSet<TblMenu> TblMenus { get; set; }

    public virtual DbSet<TblNewArrival> TblNewArrivals { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblPayMethod> TblPayMethods { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductDetail> TblProductDetails { get; set; }

    public virtual DbSet<TblProductSize> TblProductSizes { get; set; }

    public virtual DbSet<TblSlide> TblSlides { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-BFJ76VND\\NHATLO; Initial Catalog=Clothingstore; Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBanner>(entity =>
        {
            entity.ToTable("tblBanner");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Images).HasMaxLength(50);
            entity.Property(e => e.Link).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.TblBanners)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblBanner_tblCategories");

            entity.HasOne(d => d.Product).WithMany(p => p.TblBanners)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblBanner_tblProducts");
        });

        modelBuilder.Entity<TblBenefit>(entity =>
        {
            entity.ToTable("tblBenefit");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Contents).HasMaxLength(50);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Titile).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.TblBenefits)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblBenefit_tblCategories");

            entity.HasOne(d => d.Product).WithMany(p => p.TblBenefits)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblBenefit_tblProducts");
        });

        modelBuilder.Entity<TblCart>(entity =>
        {
            entity.ToTable("tblCart");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Size).WithMany(p => p.TblCarts)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_tblCart_tblProductSize");

            entity.HasOne(d => d.User).WithMany(p => p.TblCarts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblCart_tblUsers");
        });

        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.ToTable("tblCategories");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TblDealOfTheWeek>(entity =>
        {
            entity.ToTable("tblDealOfTheWeek");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Images).HasMaxLength(50);

            entity.HasOne(d => d.Product).WithMany(p => p.TblDealOfTheWeeks)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblDealOfTheWeek_tblProducts");
        });

        modelBuilder.Entity<TblFooter>(entity =>
        {
            entity.ToTable("tblFooter");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Contents).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("tblMenu");

            entity.Property(e => e.MenuId).ValueGeneratedNever();
            entity.Property(e => e.Alias).HasMaxLength(50);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasMaxLength(50);
            entity.Property(e => e.Posion).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.TblMenus)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblMenu_tblCategories");
        });

        modelBuilder.Entity<TblNewArrival>(entity =>
        {
            entity.ToTable("tblNewArrivals");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Contents).HasMaxLength(50);
            entity.Property(e => e.Imange).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasMaxLength(50);

            entity.HasOne(d => d.Product).WithMany(p => p.TblNewArrivals)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblNewArrivals_tblProducts");
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.ToTable("tblOrder");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Paymethod).WithMany(p => p.TblOrders)
                .HasForeignKey(d => d.PaymethodId)
                .HasConstraintName("FK_tblOrder_tblPayMethod");

            entity.HasOne(d => d.User).WithMany(p => p.TblOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblOrder_tblUsers");
        });

        modelBuilder.Entity<TblPayMethod>(entity =>
        {
            entity.ToTable("tblPayMethod");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.ToTable("tblProducts");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Contents).HasMaxLength(50);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Images).HasMaxLength(50);
            entity.Property(e => e.Link).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Tittle).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.TblProducts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblProducts_tblCategories");
        });

        modelBuilder.Entity<TblProductDetail>(entity =>
        {
            entity.ToTable("tblProductDetails");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Material).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasMaxLength(50);

            entity.HasOne(d => d.Product).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblProductDetails_tblProducts");

            entity.HasOne(d => d.Size).WithMany(p => p.TblProductDetails)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_tblProductDetails_tblProductSize");
        });

        modelBuilder.Entity<TblProductSize>(entity =>
        {
            entity.ToTable("tblProductSize");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Quantity).HasMaxLength(50);
            entity.Property(e => e.Size).HasMaxLength(50);

            entity.HasOne(d => d.Product).WithMany(p => p.TblProductSizes)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblProductSize_tblProducts");
        });

        modelBuilder.Entity<TblSlide>(entity =>
        {
            entity.ToTable("tblSlide");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Contents).HasMaxLength(50);
            entity.Property(e => e.Images).HasMaxLength(50);
            entity.Property(e => e.Link).HasMaxLength(50);
            entity.Property(e => e.Tittle).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.TblSlides)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblSlide_tblCategories");

            entity.HasOne(d => d.Product).WithMany(p => p.TblSlides)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblSlide_tblProducts");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.ToTable("tblUsers");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ImgUser).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
