namespace Codeblox.DigitalMenu.Domain.Extension;

public static class RepositoryExtension
{
    public static string GetConnection(this IConfiguration configurationManager)
    {
        var connection = configurationManager.GetConnectionString("Connection");
        return connection;
    }

    public static string GetNameDatabase(this IConfiguration configurationManager)
    {
        var nameDatabase = configurationManager.GetConnectionString("NameDatabase");
        return nameDatabase;
    }

    public static string GetConnectionCompletParamenter(this IConfiguration configurationManager)
    {
        var connection = configurationManager.GetConnection();
        var nameDatabase = configurationManager.GetNameDatabase();

        return $"{connection}Database={nameDatabase}";
    }
}