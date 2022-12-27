using FluentMigrator;

namespace Codeblox.DigitalMenu.Infrastructure.Migrations.Version;


[Migration((long)SpecificVersionNumber.CreateUserTable, "Criar tabela usuario")]
public class VersionData0000001 : Migration
{
    //Reverter 
    public override void Down() { }

    //Criar
    public override void Up()
    {
        var table = BaseVersion.InsertDefaultColumn(Create.Table("User"));

        table
            .WithColumn("Name").AsString(100).NotNullable()
            .WithColumn("Email").AsString(100).NotNullable()
            .WithColumn("Password").AsString(2000).NotNullable()
            .WithColumn("Phone").AsString(14).NotNullable();
    }
}