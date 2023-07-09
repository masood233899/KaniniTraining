using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace grocery_api.Models;

public partial class GroceryStoreContext : DbContext
{
    public GroceryStoreContext()
    {
    }

    public GroceryStoreContext(DbContextOptions<GroceryStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__categori__DD5DDDBDA63E8B1B");

            entity.ToTable("categories");

            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.CatName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cat_name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__products__56958AB2039C3BA3");

            entity.ToTable("products");

            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProdName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("prod_name");

            entity.HasOne(d => d.Cat).WithMany(p => p.Products)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK__products__cat_id__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
