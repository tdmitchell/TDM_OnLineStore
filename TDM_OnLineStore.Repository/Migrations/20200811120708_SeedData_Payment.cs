using Microsoft.EntityFrameworkCore.Migrations;

namespace TDM_OnLineStore.Repository.Migrations
{
    public partial class SeedData_Payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Payment by Boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Payment by Credict Card", "Credict Card" });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Payment by Deposit", "Deposit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
