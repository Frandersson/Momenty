using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102172115)]
    public class FixId_FundReturnRates : Migration
    {
        public override void Up()
        {
            Create.PrimaryKey("PK_FundReturnRates_Id").OnTable("FundReturnRates").Column("Id");
        }

        public override void Down()
        {
            Delete.PrimaryKey("PK_FundReturnRates_Id").FromTable("FundReturnRates");
        }
    }
}