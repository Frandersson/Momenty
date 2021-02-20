using FluentMigrator;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102172006)]
    public class CastDecimalToDouble_FundReturnRates : Migration
    {
        public override void Up()
        {
            Alter.Table("FundReturnRates")
                .AlterColumn("OneWeekReturn").AsDouble()
                .AlterColumn("OneMonthReturn").AsDouble()
                .AlterColumn("ThreeMonthReturn").AsDouble()
                .AlterColumn("OneYearReturn").AsDouble();
        }

        public override void Down()
        {
            Alter.Table("FundReturnRates")
                .AlterColumn("OneWeekReturn").AsDecimal()
                .AlterColumn("OneMonthReturn").AsDecimal()
                .AlterColumn("ThreeMonthReturn").AsDecimal()
                .AlterColumn("OneYearReturn").AsDecimal();
        }
    }
}