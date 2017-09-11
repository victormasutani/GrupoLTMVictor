using FluentMigrator;
using System;
using System.Security.Cryptography;

namespace Migrations
{
    [Migration(20170907165600)]
    public class _20170907165600_SeedTableUser : Migration
    {
        public override void Up()
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes("admin");
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                Insert.IntoTable("USERAPP").Row(new { DSLOGIN = "admin", DSPASSWORD = hashedInputStringBuilder.ToString() });
            }            
        }

        public override void Down()
        {
            Delete.FromTable("USERAPP").AllRows();
        }
    }
}