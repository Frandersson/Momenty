using FluentMigrator;

namespace Momenty.Web.DAL.Migrations
{
    [Migration(202102172027)]
    public class RemoveFundTable : Migration
    {
        public override void Up()
        {
            Delete.ForeignKey("FK_Funds_Id").OnTable("FundReturnRates");
            Delete.Table("Funds");
        }

        public override void Down()
        {
            Create.Table("Funds")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString();

            Create.ForeignKey("FK_Funds_Id")
                .FromTable("FundReturnRates").ForeignColumn("FundId")
                .ToTable("Funds").PrimaryColumn("Id");
        }
    }
}