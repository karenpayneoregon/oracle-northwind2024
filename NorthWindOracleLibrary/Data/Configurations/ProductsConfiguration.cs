﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Data.Configurations;

public partial class ProductsConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> entity)
    {
        entity.HasKey(e => e.ProductId);

        entity.HasIndex(e => e.CategoryId, "IDX_PRODUCTS_CATEGORY_ID");

        entity.HasIndex(e => e.SupplierId, "IDX_PRODUCTS_SUPPLIER_ID");

        entity.Property(e => e.ProductId)
            .HasPrecision(9)
            .ValueGeneratedNever();
        entity.Property(e => e.CategoryId).HasPrecision(9);
        entity.Property(e => e.Discontinued)
            .IsRequired()
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("'N'\n   ")
            .IsFixedLength();
        entity.Property(e => e.ProductName)
            .IsRequired()
            .HasMaxLength(40)
            .IsUnicode(false);
        entity.Property(e => e.QuantityPerUnit)
            .HasMaxLength(20)
            .IsUnicode(false);
        entity.Property(e => e.ReorderLevel)
            .HasPrecision(9)
            .HasDefaultValueSql("0");
        entity.Property(e => e.SupplierId).HasPrecision(9);
        entity.Property(e => e.UnitsInStock)
            .HasPrecision(9)
            .HasDefaultValueSql("0");
        entity.Property(e => e.UnitsOnOrder)
            .HasPrecision(9)
            .HasDefaultValueSql("0");
        entity.Property(e => e.UnitPrice)
            .HasDefaultValueSql("0")
            .HasColumnType("NUMBER(10,2)");

        entity.HasOne(d => d.Categories).WithMany(p => p.Products)
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CATEGORY_ID");

        entity.HasOne(d => d.Suppliers).WithMany(p => p.Products)
            .HasForeignKey(d => d.SupplierId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SUPPLIER_ID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Products> entity);
}