﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using PracticeApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApp.Models;

[Table("EMPLOYEES")]
public partial class Employees : IHasSequencer
{
    private int _id;

    [Column("EMPLOYEE_ID")]
    public int EmployeeId { get; set; }

    [Column("LASTNAME")]
    public string LastName { get; set; }

    [Column("FIRSTNAME")]
    public string FirstName { get; set; }

    [Column("TITLE")]
    public string Title { get; set; }

    [Column("TITLE_OF_COURTESY")]
    public string TitleOfCourtesy { get; set; }

    [Column("BIRTHDATE")]
    public DateTime? BirthDate { get; set; }

    [Column("HIREDATE")]
    public DateTime? HireDate { get; set; }

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

    [Column("HOME_PHONE")]
    public string HomePhone { get; set; }

    [Column("EXTENSION")]
    public string Extension { get; set; }

    [Column("PHOTO")]
    public string Photo { get; set; }

    [Column("NOTES")]
    public string Notes { get; set; }

    [Column("REPORTS_TO")]
    public int? ReportsTo { get; set; }

    public virtual ICollection<Employees> InverseReportsToNavigation { get; set; } = new List<Employees>();

    public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();

    public virtual Employees REPORTS_TONavigation { get; set; }

    [NotMapped]
    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            EmployeeId = value;
        }
    }

    public FormattableString GetSequenceStatement() 
        => $"SELECT SEQ_NW_EMPLOYEES.NEXTVAL FROM dual";
}