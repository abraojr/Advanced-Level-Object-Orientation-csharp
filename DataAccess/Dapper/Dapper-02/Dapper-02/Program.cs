using Dapper;
using Dapper_02.Models;
using Microsoft.Data.SqlClient;
using System;

namespace Dapper_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                ListCategories(connection); // SELECT OPERATION
                CreateCategory(connection); // INSERT OPERTATION
            }
        }

        static void ListCategories(SqlConnection connection)
        {
            var categories = connection.Query<Category>("SELECT [Id], Title FROM CATEGORY");

            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Id} - {item.Title}");
            }
        }

        static void CreateCategory(SqlConnection connection)
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon AWS";
            category.Url = "amazon";
            category.Description = "Category for AWS Services";
            category.Order = 8;
            category.Summary = "AWS Cloud";
            category.Featured = false;

            var insertSql = @"INSERT INTO
                       [Category]
                   VALUES(
                          @Id,
                          @Title,
                          @Url,
                          @Description,
                          @Order,
                          @Summary,
                          @Featured)";

            var rows = connection.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Description,
                category.Order,
                category.Summary,
                category.Featured
            });

            Console.WriteLine($"{rows} rows affected");
        }
    }
}
