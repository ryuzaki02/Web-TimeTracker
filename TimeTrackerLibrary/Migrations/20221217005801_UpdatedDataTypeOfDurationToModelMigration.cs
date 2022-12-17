using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeTrackerLibrary.Migrations
{
    public partial class UpdatedDataTypeOfDurationToModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "TimeSheets",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Duration",
                table: "TimeSheets",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "TimeSheets");
        }
    }
}
