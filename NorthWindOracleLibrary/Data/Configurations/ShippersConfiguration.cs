﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Data.Configurations;

public partial class ShippersConfiguration : IEntityTypeConfiguration<Shippers>
{
    public void Configure(EntityTypeBuilder<Shippers> entity)
    {
        entity.HasKey(e => e.ShipperId);

        entity.Property(e => e.ShipperId)
            .HasPrecision(9)
            .ValueGeneratedNever();
        entity.Property(e => e.CompanyName)
            .IsRequired()
            .HasMaxLength(40)
            .IsUnicode(false);
        entity.Property(e => e.Phone)
            .HasMaxLength(24)
            .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Shippers> entity);
}