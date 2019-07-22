using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagment.Migrations
{
    public partial class SeedPeapleBrokers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Brokers (Name) VALUES ('FxPro')");
            migrationBuilder.Sql("INSERT INTO PEOPLE(Name,BrokerId) Values ('Mahamed Atef',(Select BrokerId From Brokers Where Name='FxPro'))");
            migrationBuilder.Sql("INSERT INTO PEOPLE(Name,BrokerId) Values ('Mazen Mohamed',(Select BrokerId From Brokers Where Name='FxPro'))");

        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM People WHERE Name In('Mahamed Atef','Mazen Mohamed')");
            migrationBuilder.Sql("DELETE FROM Brokers WHERE Name In('FxPro')");
        }
    }
}
