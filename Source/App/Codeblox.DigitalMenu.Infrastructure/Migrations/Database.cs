using Dapper;
using System.Data.SqlClient;

namespace Codeblox.DigitalMenu.Infrastructure.Migrations;

public static class Database
{
    public static void CreateDatabase(string connectionWithoutDataBase, string nameDatabase)
    {
        using var connection = new SqlConnection(connectionWithoutDataBase);
        connection.Open();

        var startingQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = @Name";
        var paramToCreate = new { Name = nameDatabase };
        var hasDatabase = connection.ExecuteScalar<int>(startingQuery, paramToCreate) != 0;

        if (!hasDatabase)
        {
            connection.Close();
            using var connection2 = new SqlConnection(connectionWithoutDataBase);
            connection2.Open();
            var databaseQuery = $"CREATE DATABASE {nameDatabase}";
            connection2.Execute(databaseQuery);
        }
    }
}