namespace Codeblox.DigitalMenu.API.Settings
{
    public class UpData
    {
        public static void UpdateDataBase()
        {
            var builder = WebApplication.CreateBuilder();

            var connection = builder.Configuration.GetConnection();
            var nameDatabase = builder.Configuration.GetNameDatabase();

            Database.CreateDatabase(connection, nameDatabase);
        }
    }
}