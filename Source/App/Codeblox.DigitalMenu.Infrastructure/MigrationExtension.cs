namespace Codeblox.DigitalMenu.Infrastructure;

public static class MigrationExtension
{
    public static void MigrateDataBase(this IApplicationBuilder applicationBuilder)
    {
        using var scope = applicationBuilder.ApplicationServices.CreateScope();
        var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

        runner.ListMigrations(); //Testar migrations disponiveis.

        runner.MigrateUp(); //Chamar migrations
    }
}