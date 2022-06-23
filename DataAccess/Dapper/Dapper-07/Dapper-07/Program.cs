using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Dapper_07
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                ExecuteReadProcedure(connection);
            }
        }

        static void ExecuteReadProcedure(SqlConnection connection)
        {
            var procedure = "[spGetCoursesByCategory]";
            var parameters = new { CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };
            var courses = connection.Query(procedure, parameters, commandType: CommandType.StoredProcedure);

            foreach (var item in courses)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
