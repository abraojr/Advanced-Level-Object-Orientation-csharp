using Dapper;
using Dapper_14.Models;
using Microsoft.Data.SqlClient;
using System;

namespace Dapper_14
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                Like(connection, "api");
            }
        }

        static void Like(SqlConnection connection, string term)
        {
            var query = @"SELECT * FROM [Course] WHERE [Title] LIKE @exp";

            var items = connection.Query<Course>(query, new
            {
                exp = $"%{term}%"
            });

            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
