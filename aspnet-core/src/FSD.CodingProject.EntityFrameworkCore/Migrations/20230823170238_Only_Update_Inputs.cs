using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD.CodingProject.Migrations
{
    /// <inheritdoc />
    public partial class OnlyUpdateInputs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatrollrevenuePercent",
                table: "AppCalculationInputs",
                newName: "PayrollRevenuePercent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PayrollRevenuePercent",
                table: "AppCalculationInputs",
                newName: "PatrollrevenuePercent");
        }
    }
}
