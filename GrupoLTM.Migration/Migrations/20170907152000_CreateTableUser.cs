using FluentMigrator;

namespace Migrations
{
    [Migration(20170907152000)]
    public class _20170907152000_CreateTableUser : Migration
    {
        public override void Up()
        {
            Create.Table("USERAPP")
                .WithColumn("IDUSERAPP").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("DSLOGIN").AsString(100).NotNullable()
                .WithColumn("DSPASSWORD").AsString(128).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("USERAPP");
        }
    }
}