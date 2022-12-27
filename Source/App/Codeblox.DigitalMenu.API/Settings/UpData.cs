using Codeblox.DigitalMenu.Infrastructure.Migrations;

namespace Codeblox.DigitalMenu.API.Settings
{
    public class UpData
    {
        public static void UpdateDataBase()
        {
            var builder = WebApplication.CreateBuilder();

            var connection = builder.Configuration.GetConnectionString("Connection");
            var nameDatabase = builder.Configuration.GetConnectionString("NameDatabase");

            Database.CreateDatabase(connection, nameDatabase);
        }
    }
}
