using FluentMigrator;

namespace Migrations
{
    [Migration(20170907155300)]
    public class _20170907155300_CreateTableProduct : Migration
    {
        public override void Up()
        {
            Create.Table("PRODUCT")
                .WithColumn("IDPRODUCT").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("DSPRODUCT").AsString(100).NotNullable()
                .WithColumn("VLPRODUCT").AsCurrency().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("PRODUCT");
        }
    }
}