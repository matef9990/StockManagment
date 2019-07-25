using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagment.Migrations
{
    public partial class DeletePeopleBrokerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleBrokers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeopleBrokers",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    BrokerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleBrokers", x => new { x.PersonId, x.BrokerId });
                    table.ForeignKey(
                        name: "FK_PeopleBrokers_Brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "Brokers",
                        principalColumn: "BrokerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleBrokers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleBrokers_BrokerId",
                table: "PeopleBrokers",
                column: "BrokerId");
        }
    }
}
