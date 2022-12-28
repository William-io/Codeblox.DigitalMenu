namespace Codeblox.DigitalMenu.Infrastructure;

public static class Bootmigration
{
    public static void AddRepository(this IServiceCollection services, IConfiguration configurationManager)
    {
        AddFluentMigrator(services, configurationManager);
    }

    private static void AddFluentMigrator(IServiceCollection services, IConfiguration configurationManager)
    {
        services.AddFluentMigratorCore().ConfigureRunner(c =>
        c.AddSqlServer()
        .WithGlobalConnectionString(configurationManager.GetConnectionCompletParamenter())
        .ScanIn(Assembly.Load("Codeblox.DigitalMenu.Infrastructure")).For.All());
    }
}