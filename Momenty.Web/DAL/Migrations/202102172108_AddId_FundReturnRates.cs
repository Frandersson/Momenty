using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102172108)]
    public class AddId_FundReturnRates : Migration
    {
        public override void Up()
        {
            Alter.Table("FundReturnRates")
                .AddColumn("Id").AsInt64().PrimaryKey().NotNullable().Identity();
        }

        public override void Down()
        {
            Delete.Column("Id")
                .FromTable("FundReturnRates");
        }
    }
}