using Dapper;
using Dapper_13.Models;
using Microsoft.Data.SqlClient;
using System;

namespace Dapper_13
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                SelectIn(connection);
            }
        }

        static void SelectIn(SqlConnection connection)
        {
            var query = @"SELECT * FROM [Career] WHERE [Id] IN @Id";

            var items = connection.Query<Career>(query, new
            {
                Id = new[]{
                    "4327ac7e-963b-4893-9f31-9a3b28a4e72b",
                    "e6730d1c-6870-4df3-ae68-438624e04c72"
                }
            });

            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
            }

        }
    }
}
