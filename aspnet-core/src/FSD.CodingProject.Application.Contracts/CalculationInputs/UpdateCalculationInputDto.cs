using System;
using System.ComponentModel.DataAnnotations;
namespace FSD.CodingProject.CalculationInputs
{
    public class UpdateCalculationInputDto
    {
        [Required]
        public int JobsPerMonth { get; set; }
        [Required]
        public decimal PayrollRevenuePercent { get; set; }
        [Required]
        public decimal BillRatePerJob { get; set; }
        [Required]
        public decimal PercentRecurringHomesLostPerMonth { get; set; }
        [Required]
        public decimal PercentNetProfit { get; set; }
        [Required]
        public decimal PercentRateIncrease { get; set; }
        [Required]
        public decimal PercentExpectedJobLoss { get; set; }
        [Required]
        public decimal LowerPayrollRevenuePercent { get; set; }
        [Required]
        public decimal ImproveRecurringHomesLostPerMonthPercent { get; set; }
        
        public CalculationType.CalculationType CalculationType { get; set; }
    }
}
