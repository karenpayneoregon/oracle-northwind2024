﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NorthWindOracleLibrary.Classes;
using NorthWindOracleLibrary.Data.Configurations;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Data;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Categories> Categories { get; set; }

    public virtual DbSet<Customers> Customers { get; set; }

    public virtual DbSet<Employees> Employees { get; set; }

    public virtual DbSet<Orders> Orders { get; set; }

    public virtual DbSet<OrderDetails> OrderDetails { get; set; }

    public virtual DbSet<Products> Products { get; set; }

    public virtual DbSet<Shippers> Shippers { get; set; }

    public virtual DbSet<Suppliers> Suppliers { get; set; }
    public virtual DbSet<ContactType> ContactType { get; set; }

    /// <summary>
    /// Setup for desktop or web
    /// </summary>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseOracle(ConnectionString()).EnableSensitiveDataLogging()
                .LogTo(new DbContextToFileLogger().Log,
                    new[]
                    {
                        DbLoggerCategory.Database.Command.Name
                    },
                    LogLevel.Information);
        }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("NORTHWIND")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        modelBuilder.ApplyConfiguration(new CustomersConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
        modelBuilder.ApplyConfiguration(new OrdersConfiguration());
        modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());
        modelBuilder.ApplyConfiguration(new ProductsConfiguration());
        modelBuilder.ApplyConfiguration(new ShippersConfiguration());
        modelBuilder.ApplyConfiguration(new SuppliersConfiguration());
        modelBuilder.HasSequence("SEQ_NW_CATEGORIES");
        modelBuilder.HasSequence("SEQ_NW_CUSTOMERS");
        modelBuilder.HasSequence("SEQ_NW_EMPLOYEES");
        modelBuilder.HasSequence("SEQ_NW_ORDERS");
        modelBuilder.HasSequence("SEQ_NW_PRODUCTS");
        modelBuilder.HasSequence("SEQ_NW_SHIPPERS");
        modelBuilder.HasSequence("SEQ_NW_SUPPLIERS");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
