﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using PracticeApp.Data.Configurations;
using PracticeApp.Models;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using PracticeApp.Classes;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.CompilerServices;
using Dapper;
using Oracle.ManagedDataAccess.Client;

#nullable disable

namespace PracticeApp.Data;

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

        modelBuilder.ApplyConfiguration(new Configurations.CategoriesConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CustomersConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeesConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdersConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrderDetailsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ShippersConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SuppliersConfiguration());
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

    public override int SaveChanges()
    {
        var addedEntries = ChangeTracker
            .Entries()
            .Where(e => e.State == EntityState.Added);

        foreach (var entry in addedEntries)
        {
            if (entry.Entity is IHasSequencer sequencerEntity)
            {
                sequencerEntity.Id = Database.GetDbConnection()
                    .QuerySingle<int>(sequencerEntity.GetSequenceStatement().ToString());
            }
        }

        return base.SaveChanges();
    }

}
