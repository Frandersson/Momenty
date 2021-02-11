using FluentMigrator;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102112155)]
    public class AddFundReturnRatesTable : Migration
    {
        public override void Up()
        {
            Create.Table("FundReturnRates")
                .WithColumn("FundId").AsInt64()
                .WithColumn("OneMonthReturn").AsDecimal()
                .WithColumn("ThreeMonthReturn").AsDecimal()
                .WithColumn("OneYearReturn").AsDecimal()
                .WithColumn("DateOfScrape").AsDateTime();

            Create.ForeignKey("FK_Funds_Id")
                .FromTable("FundReturnRates").ForeignColumn("FundId")
                .ToTable("Funds").PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.ForeignKey("FK_Funds_Id").OnTable("FundReturnRates");

            Delete.Table("FundReturnRates");
        }
    }
}