﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApp.Models;

[Table("SHIPPERS")]
public partial class Shippers
{
    public int SHIPPER_ID { get; set; }

    public string COMPANY_NAME { get; set; }

    public string PHONE { get; set; }

    public virtual ICollection<Orders> ORDERS { get; set; } = new List<Orders>();
}