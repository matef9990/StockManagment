using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagment.Migrations
{
    public partial class EditOrdersTableToMakePersonOnlyNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Brokers_BrokerId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "BrokerId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Brokers_BrokerId",
                table: "Orders",
                column: "BrokerId",
                principalTable: "Brokers",
                principalColumn: "BrokerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Brokers_BrokerId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "BrokerId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Brokers_BrokerId",
                table: "Orders",
                column: "BrokerId",
                principalTable: "Brokers",
                principalColumn: "BrokerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
