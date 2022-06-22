using Dapper;
using Dapper_01.Models;
using Microsoft.Data.SqlClient;
using System;

namespace Dapper_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                var categories = connection.Query<Category>("SELECT [Id], Title FROM CATEGORY");

                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Id} - {category.Title}");
                }
            }

        }
    }
}
