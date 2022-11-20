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
    }

    public static IDbConnection CreateConnection()
    {
        string connectionString = @"Server=(local); Database=AdventureWorks2019; Integrated Security=True";
        return new SqlConnection(connectionString);
    }
}
