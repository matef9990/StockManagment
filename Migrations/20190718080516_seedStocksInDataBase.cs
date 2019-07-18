using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagment.Migrations
{
    public partial class SeedStocksInDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Stocks (Name,Price) VALUES ('Vianet',0),('Agritrk',0),('Akamai',0),('Baidu',0),('Blinks',0),('Blucora',0),('Boingo',0),('Brainybrawn',0),('Carbonite',0),('China Finance',0),('ChinaCashe',0),('ADR',0),('Chitrchatr',0),('Cnova',0),('Cogent',0),('Crexendo',0),('CrowdGather',0),('EarthLink',0),('Eastern',0),('ENDEXX',0),('Envestnet',0),('Epazz',0),('FlashZero',0),('Genesis',0),('InterNap',0),('MeetMe',0),('Netease',0),('Qihoo',0)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM Stocks Where Name In ('Vianet','Agritrk','Akamai','Baidu','Blinks','Blucora','Boingo','Brainybrawn','Carbonite','China Finance','ChinaCashe','ADR','Chitrchatr','Cnova','Cogent','Crexendo','CrowdGather','EarthLink','Eastern','ENDEXX','Envestnet','Epazz','FlashZero','Genesis','InterNap','MeetMe','Netease','Qihoo')");
            

        }
    }
}
