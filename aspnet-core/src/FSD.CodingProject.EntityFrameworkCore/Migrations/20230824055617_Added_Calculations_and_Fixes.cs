using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD.CodingProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedCalculationsandFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImproveRecurringHomesLostPerMonthPercent",
                table: "AppCalculationInputs");

            migrationBuilder.DropColumn(
                name: "PercentRecurringHomesLostPerMonth",
                table: "AppCalculationInputs");

            migrationBuilder.AlterColumn<decimal>(
                name: "PercentRateIncrease",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "PercentNetProfit",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "PercentExpectedJobLoss",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "PayrollRevenuePercent",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "LowerPayrollRevenuePercent",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<decimal>(
                name: "ImproveRecurringHomesLostPerMonthPercent",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PercentRecurringHomesLostPerMonth",
                table: "AppCalculationInputs",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImproveRecurringHomesLostPerMonthPercent",
                table: "AppCalculationInputs");

            migrationBuilder.DropColumn(
                name: "PercentRecurringHomesLostPerMonth",
                table: "AppCalculationInputs");

            migrationBuilder.AlterColumn<double>(
                name: "PercentRateIncrease",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "PercentNetProfit",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "PercentExpectedJobLoss",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "PayrollRevenuePercent",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "LowerPayrollRevenuePercent",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddColumn<double>(
                name: "ImproveRecurringHomesLostPerMonthPercent",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PercentRecurringHomesLostPerMonth",
                table: "AppCalculationInputs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
