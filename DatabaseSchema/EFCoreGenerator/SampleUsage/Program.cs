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
        var conn = CreateConnection();
        var products = conn.Query<Product>("SELECT * FROM Production.Product");
        foreach (var product in products)
            Console.WriteLine(product.Name);

        var p1 = products.First();
        p1.Name = "newName";
        var dal = new DataAccessLayer(_connectionString);
        dal.Save(p1); // Save() will automatically check if it should call .Update() or .Insert()

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

        dal.Save(p2); // Save() will automatically check if it should call .Update() or .Insert()
    }

    static string _connectionString = @"Server=(local); Database=AdventureWorks2019; Integrated Security=True";
    public static IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
