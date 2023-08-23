using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD.CodingProject.Migrations
{
    /// <inheritdoc />
    public partial class CreatedCalculationInputEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCalculationInputs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobsPerMonth = table.Column<int>(type: "int", nullable: false),
                    PatrollrevenuePercent = table.Column<double>(type: "float", nullable: false),
                    BillRatePerJob = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecurringHomesLostPerMonth = table.Column<double>(type: "float", nullable: false),
                    NetProfit = table.Column<double>(type: "float", nullable: false),
                    PercentRateIncrease = table.Column<double>(type: "float", nullable: false),
                    PercentExpectedJobLoss = table.Column<double>(type: "float", nullable: false),
                    LowerPayrollRevenuePercent = table.Column<double>(type: "float", nullable: false),
                    ImproveRecurringHomesLostPerMonth = table.Column<double>(type: "float", nullable: false),
                    CalculationType = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCalculationInputs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCalculationInputs");
        }
    }
}
