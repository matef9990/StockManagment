using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagment.Migrations
{
    public partial class EditOrdersTableToMakePersonAndBrokerNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Brokers_BrokerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_PersonId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_PersonId",
                table: "Orders",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Brokers_BrokerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_PersonId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_PersonId",
                table: "Orders",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
