using System.Text.Json;
using PracticeApp.Models;

namespace PracticeApp.Classes;
public class ReferenceLists
{
    public static List<ContactType> CustomerTitles()
    {
        var json = 
            """
            [
              {
                "ContactTypeIdentifier": 1,
                "ContactTitle": "Accounting Manager"
              },
              {
                "ContactTypeIdentifier": 2,
                "ContactTitle": "Assistant Sales Agent"
              },
              {
                "ContactTypeIdentifier": 3,
                "ContactTitle": "Assistant Sales Representative"
              },
              {
                "ContactTypeIdentifier": 4,
                "ContactTitle": "Marketing Assistant"
              },
              {
                "ContactTypeIdentifier": 5,
                "ContactTitle": "Marketing Manager"
              },
              {
                "ContactTypeIdentifier": 6,
                "ContactTitle": "Order Administrator"
              },
              {
                "ContactTypeIdentifier": 7,
                "ContactTitle": "Owner"
              },
              {
                "ContactTypeIdentifier": 8,
                "ContactTitle": "Owner/Marketing Assistant"
              },
              {
                "ContactTypeIdentifier": 9,
                "ContactTitle": "Sales Agent"
              },
              {
                "ContactTypeIdentifier": 10,
                "ContactTitle": "Sales Associate"
              },
              {
                "ContactTypeIdentifier": 11,
                "ContactTitle": "Sales Manager"
              },
              {
                "ContactTypeIdentifier": 12,
                "ContactTitle": "Sales Representative"
              },
              {
                "ContactTypeIdentifier": 13,
                "ContactTitle": "Vice President, Sales"
              }
            ]
            """;

        return JsonSerializer.Deserialize<List<ContactType>>(json)!;
    }

    public static List<ContactType> ContactTypes 
        => CustomerTitles();

    public static List<Countries> CountriesList()
    {
        var json = 
            """
            [
              {
                "CountryIdentifier": 1,
                "CountryName": "Argentina"
              },
              {
                "CountryIdentifier": 2,
                "CountryName": "Austria"
              },
              {
                "CountryIdentifier": 3,
                "CountryName": "Belgium"
              },
              {
                "CountryIdentifier": 4,
                "CountryName": "Brazil"
              },
              {
                "CountryIdentifier": 5,
                "CountryName": "Canada"
              },
              {
                "CountryIdentifier": 6,
                "CountryName": "Denmark"
              },
              {
                "CountryIdentifier": 7,
                "CountryName": "Finland"
              },
              {
                "CountryIdentifier": 8,
                "CountryName": "France"
              },
              {
                "CountryIdentifier": 9,
                "CountryName": "Germany"
              },
              {
                "CountryIdentifier": 10,
                "CountryName": "Ireland"
              },
              {
                "CountryIdentifier": 11,
                "CountryName": "Italy"
              },
              {
                "CountryIdentifier": 12,
                "CountryName": "Mexico"
              },
              {
                "CountryIdentifier": 13,
                "CountryName": "Norway"
              },
              {
                "CountryIdentifier": 14,
                "CountryName": "Poland"
              },
              {
                "CountryIdentifier": 15,
                "CountryName": "Portugal"
              },
              {
                "CountryIdentifier": 16,
                "CountryName": "Spain"
              },
              {
                "CountryIdentifier": 17,
                "CountryName": "Sweden"
              },
              {
                "CountryIdentifier": 18,
                "CountryName": "Switzerland"
              },
              {
                "CountryIdentifier": 19,
                "CountryName": "UK"
              },
              {
                "CountryIdentifier": 20,
                "CountryName": "USA"
              },
              {
                "CountryIdentifier": 21,
                "CountryName": "Venezuela"
              }
            ]
            """;

        return JsonSerializer.Deserialize<List<Countries>>(json)!;
    }
}
