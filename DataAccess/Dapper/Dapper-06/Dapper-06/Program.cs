using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Dapper_06
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=localhost,1433; Database=balta; User ID=sa; Password=SenhaDoSA123; Encrypt=False";

            using (var connection = new SqlConnection(connectionString))
            {
                ExecuteProcedure(connection);
            }
        }

        static void ExecuteProcedure(SqlConnection connection)
        {
            var procedure = "[spDeleteStudent]";
            var parameters = new { StudentId = "691a068f-6782-40e1-bf69-d5a6a08ee298" };
            var rows = connection.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);

            Console.WriteLine($"{rows} rows affected");
        }
    }
}
