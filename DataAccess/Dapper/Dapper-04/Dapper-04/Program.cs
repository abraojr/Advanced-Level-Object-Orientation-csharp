using Dapper;
using Dapper_04.Models;
using Microsoft.Data.SqlClient;
using System;

namespace Dapper_04
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                GetCategory(connection); // SELECT TOP
                DeleteCategory(connection); // DELETE OPERATION
            }
        }

        static void GetCategory(SqlConnection connection)
        {
            var category = connection
                .QueryFirstOrDefault<Category>(
                    "SELECT TOP 1 [Id], [Title] FROM [Category] WHERE [Id]=@id",
                    new
                    {
                        id = "45444105-a436-43c7-938d-2b0eb26e95e7"
                    }
                );

            Console.WriteLine($"{category.Id} - {category.Title}");
        }

        static void DeleteCategory(SqlConnection connection)
        {
            var deleteQuery = "DELETE FROM [Category] WHERE [Id]=@id";
            var rows = connection.Execute(deleteQuery, new
            {
                id = new Guid("45444105-a436-43c7-938d-2b0eb26e95e7"),
            });

            Console.WriteLine($"{rows} rows affected");
        }
    }
}
