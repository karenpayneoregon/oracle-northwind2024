using PracticeApp.Data;
using PracticeApp.Models;
using System.Data;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace PracticeApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        _cn = new OracleConnection(ConnectionString());
    }

    private void FixSupplierRegionButton_Click(object sender, EventArgs e)
    {
        using var context = new Context();
        var list = context.Suppliers.Where(x => x.Region.Contains("?")).ToList();
        if (list.Count > 0)
        {
            foreach (var item in list)
            {
                item.Region = "Quebec";
            }

            var affected = context.SaveChanges();
            if (affected == list.Count)
            {
                MessageBox.Show("Fixed");
            }
            else
            {
                MessageBox.Show("Not fixed");
            }
        }
        else
        {
            MessageBox.Show("Already handled");
        }

    }
    /// <summary>
    /// Add new record
    /// - From sequence fetch the next id
    /// - Set EmployeeId to above
    /// - Save record
    /// </summary>
    /// <remarks>
    /// </remarks>
    private void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        int GetIdentifier()
        {
            var id = _cn.QuerySingle<int>("SELECT SEQ_NW_EMPLOYEES.NEXTVAL FROM dual");
            return id;
        }

        using var context = new Context();

        Employees employees = new Employees
        {
            FirstName = "Jim",
            LastName = "Smith",
            Title = "Manager",
            TitleOfCourtesy = "Mr",
            BirthDate = new DateTime(1957, 1, 12, 13, 1, 1),
            HireDate = new DateTime(2023, 1, 12, 13, 1, 1),
            Address = "15 Apple Street",
            City = "Portland",
            Region = "PX",
            PostalCode = "97643",
            Photo = "jim.png",
            Notes = "Just added",
            ReportsTo = 2,
            EmployeeId = GetIdentifier()
        };
        context.Add(employees);
        context.SaveChanges();
    }

    private IDbConnection _cn;


}
