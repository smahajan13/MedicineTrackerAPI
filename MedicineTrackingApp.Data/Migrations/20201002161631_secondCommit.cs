using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineTrackingApp.Data.Migrations
{
    public partial class secondCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "MedicineDetails",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MedicineDetails",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
