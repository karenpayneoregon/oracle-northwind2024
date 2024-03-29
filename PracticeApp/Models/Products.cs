﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApp.Models;

[Table("PRODUCTS")]
public partial class Products
{
    public int PRODUCT_ID { get; set; }

    public string PRODUCT_NAME { get; set; }

    public int SUPPLIER_ID { get; set; }

    public int CATEGORY_ID { get; set; }

    public string QUANTITY_PER_UNIT { get; set; }

    public decimal UNIT_PRICE { get; set; }

    public int UNITS_IN_STOCK { get; set; }

    public int UNITS_ON_ORDER { get; set; }

    public int REORDER_LEVEL { get; set; }

    public string DISCONTINUED { get; set; }

    public virtual Categories CATEGORY { get; set; }

    public virtual ICollection<OrderDetails> ORDER_DETAILS { get; set; } = new List<OrderDetails>();

    public virtual Suppliers SUPPLIER { get; set; }
}