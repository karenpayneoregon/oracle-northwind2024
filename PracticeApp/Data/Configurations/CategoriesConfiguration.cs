﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeApp.Data;
using PracticeApp.Models;
using System;
using System.Collections.Generic;

namespace PracticeApp.Data.Configurations
{
    public partial class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> entity)
        {
            entity.HasKey(e => e.CATEGORY_ID);

            entity.HasIndex(e => e.CATEGORY_NAME, "UIDX_CATEGORY_NAME").IsUnique();

            entity.Property(e => e.CATEGORY_ID)
            .HasPrecision(9)
            .ValueGeneratedNever();
            entity.Property(e => e.CATEGORY_NAME)
            .IsRequired()
            .HasMaxLength(15)
            .IsUnicode(false);
            entity.Property(e => e.DESCRIPTION)
            .HasMaxLength(2000)
            .IsUnicode(false);
            entity.Property(e => e.PICTURE)
            .HasMaxLength(255)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Categories> entity);
    }
}
