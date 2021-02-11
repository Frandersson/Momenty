using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102112113)]
    public class AddFundTable : Migration
    {
        public override void Up()
        {
            Create.Table("Funds")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString();
        }

        public override void Down()
        {
            Delete.Table("Funds");
        }
    }
}