using Dapper;
using MyNamespace;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MyNamespace.Crud; // Extension is here - at DataAccessLayer class

/// <summary>
/// Sample
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        var conn = CreateConnection();
        var products = conn.Query<Product>("SELECT * FROM Production.Product");
        foreach (var product in products)
            Console.WriteLine(product.Name);

        var p1 = products.First();
        p1.Name = "newName";
        conn.Save(p1); // Extension is at DataAccessLayer class. // Save() will automatically check if it should call .Update() or .Insert()

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

        conn.Save(p2); // Extension is at DataAccessLayer class. // Save() will automatically check if it should call .Update() or .Insert()
    }

    public static IDbConnection CreateConnection()
    {
        string connectionString = @"Server=(local); Database=AdventureWorks2019; Integrated Security=True";
        return new SqlConnection(connectionString);
    }
}
