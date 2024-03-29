﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApp.Models;
[Table("SUPPLIERS")]
public partial class Suppliers
{
    [Column("SUPPLIER_ID")]
    public int SupplierId { get; set; }

    [Column("COMPANY_NAME")]
    public string CompanyName { get; set; }

    [Column("CONTACT_NAME")]
    public string ContactName { get; set; }

    [Column("CONTACT_TITLE")]
    public string ContactTitle { get; set; }
    
    [Column("ADDRESS")]
    public string Address { get; set; }

    [Column("CITY")]
    public string City { get; set; }

    [Column("REGION")]
    public string Region { get; set; }

    [Column("POSTAL_CODE")]
    public string PostalCode { get; set; }

    [Column("COUNTRY")]
    public string Country { get; set; }

    [Column("PHONE")]
    public string Phone { get; set; }

    public string FAX { get; set; }

    [Column("HOME_PAGE")]
    public string HomePage { get; set; }

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();

    public override string ToString() => CompanyName;

}