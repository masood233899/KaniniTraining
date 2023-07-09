using System;
using System.Collections.Generic;
using DepartmentalStores.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentalStores.Data;

public partial class DepartmentalStoresContext : DbContext
{
    public DepartmentalStoresContext()
    {
    }

    public DepartmentalStoresContext(DbContextOptions<DepartmentalStoresContext> options)
        : base(options)
    {
    }


    public virtual DbSet<ProductsUpdated> ProductsUpdateds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<ProductsUpdated>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED8B18567C");

            entity.ToTable("ProductsUpdated");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.AvailableQuantity)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Available_Quantity");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Product).HasMaxLength(20);
            entity.Property(e => e.ProductSection)
                .HasMaxLength(20)
                .HasColumnName("Product_Section");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
