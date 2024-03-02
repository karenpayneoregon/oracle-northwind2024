﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace NorthWindOracleLibrary.Models;

[Table("SUPPLIERS")]
public partial class Suppliers
{
    [Column("SUPPLIER_ID")]
    public int SupplierId { get; set; }

    [Column("COMPANY_NAME")]
    public string CompanyName { get; set; }

    [Column("CONTACT_NAME")]
    public string ContactFullName { get; set; }

    [Column("CONTACT_TITLE")]
    public string ContactTile { get; set; }

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

    public string PHONE { get; set; }

    public string FAX { get; set; }

    public string HOME_PAGE { get; set; }

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}