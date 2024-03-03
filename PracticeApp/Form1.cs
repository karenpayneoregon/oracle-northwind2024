using PracticeApp.Data;
using PracticeApp.Models;
using System.Data;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using System.Text.Json;
using PracticeApp.Classes;

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
    /// See the DbContext SaveChanges which gets the primary key for the new <see cref="Employees"/> record
    /// </summary>
    private void AddEmployeeButton_Click(object sender, EventArgs e)
    {
        using var context = new Context();

        Employees employees = new Employees
        {
            FirstName = "Karen",
            LastName = "Adams",
            Title = "Manager",
            TitleOfCourtesy = "Mr",
            BirthDate = new DateTime(1957, 1, 12, 13, 1, 1),
            HireDate = new DateTime(2023, 1, 12, 13, 1, 1),
            Address = "15 Apple Street",
            City = "Portland",
            Region = "PX",
            PostalCode = "97643",
            Photo = "karen.png",
            Notes = "Just added",
            ReportsTo = 2,
        };
        context.Add(employees);
        context.SaveChanges();
    }

    private IDbConnection _cn;

    private void Form1_Load(object sender, EventArgs e)
    {
        CountriesComboBox.DataSource = ReferenceData.Instance.CountriesList;
        CountriesComboBox.SelectedIndex = -1;
    }

    private void CurrentCountryButton_Click(object sender, EventArgs e)
    {
        if (CountriesComboBox.SelectedIndex > -1)
        {
            var item = (Countries)CountriesComboBox.SelectedItem!;
            MessageBox.Show($"{item.CountryIdentifier} {item.CountryName}");
        }
        
    }
}
