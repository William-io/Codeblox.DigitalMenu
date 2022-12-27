using Microsoft.Extensions.Configuration;

namespace Codeblox.DigitalMenu.Domain.Extension;

public static class RepositoryExtension
{
    public static string GetConnectionString(this IConfiguration configurationManager)
    {
        var connection = configurationManager.GetConnectionString("Connection");
        return connection;
    }

    public static string GetNameDatabase(this IConfiguration configurationManager)
    {
        var nameDatabase = configurationManager.GetConnectionString("NameDatabase");
        return nameDatabase;
    }
}