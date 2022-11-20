using Dapper;
using MyNamespace;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

/// <summary>
/// Sample
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        var conn = IDbConnectionFactory.CreateConnection(); // Please adjust your connection string! Or (better) move it to appsettings. ActiveRecord uses this.

        var products = conn.Query<Product>("SELECT * FROM Production.Product");
        foreach (var product in products)
            Console.WriteLine(product.Name);

        var p1 = products.First();
        p1.Name = "newName";
        p1.Save(); // Save() will automatically check if it should call .Update() or .Insert()

        var p2 = new Product()
        {
            // Mandatory fields
            Name = "NewProduct",
            ModifiedDate = DateTime.Now,
            SellStartDate = DateTime.Now,
            ProductNumber = "",
            SafetyStockLevel = 10,
            ReorderPoint = 1,
        };

        p2.Save(); // Save() will automatically check if it should call .Update() or .Insert()
    }

    public static IDbConnection CreateConnection()
    {
        string connectionString = @"Server=(local); Database=AdventureWorks2019; Integrated Security=True";
        return new SqlConnection(connectionString);
    }
}
