using FluentMigrator;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102171827)]
    public class AddFields_FundReturnTable : Migration
    {
        public override void Up()
        {
            Alter.Table("FundReturnRates")
                .AddColumn("OneWeekReturn").AsDecimal()
                .AddColumn("SortedOn").AsString();
        }

        public override void Down()
        {
            Delete.Column("OneWeekReturn")
                .Column("SortedOn")
                .FromTable("FundReturnRates");
        }
    }
}