using FluentMigrator;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102172031)]
    public class AlterFundIdToFundName_FundReturnRates : Migration
    {
        public override void Up()
        {
            Rename.Column("FundId").OnTable("FundReturnRates").To("FundName");

            Alter.Table("FundReturnRates").AlterColumn("FundName").AsString();
        }

        public override void Down()
        {
            Rename.Column("FundName").OnTable("FundReturnRates").To("FundId");

            Alter.Table("FundReturnRates").AlterColumn("FundId").AsInt64();
        }
    }
}