namespace Codeblox.DigitalMenu.Infrastructure.Migrations;

public static class BaseVersion
{
    public static ICreateTableColumnOptionOrWithColumnSyntax InsertDefaultColumn(ICreateTableWithColumnOrSchemaOrDescriptionSyntax table)
    {
        return table
             .WithColumn("Id").AsInt64().PrimaryKey().Identity()
             .WithColumn("CreateDate").AsDateTime().NotNullable();
    }
}

