using System;
using System.ComponentModel.DataAnnotations;
namespace FSD.CodingProject.CalculationInputs
{
    public class UpdateCalculationInputDto
    {
        [Required]
        public int JobsPerMonth { get; set; }
        [Required]
        public double PatrollRevenuePercent { get; set; }
        [Required]
        public decimal BillRatePerJob { get; set; }
        [Required]
        public double RecurringHomesLostPerMonth { get; set; }
        [Required]
        public double NetProfit { get; set; }
        [Required]
        public double PercentRateIncrease { get; set; }
        [Required]
        public double PercentExpectedJobLoss { get; set; }
        [Required]
        public double LowerPayrollRevenuePercent { get; set; }
        [Required]
        public double ImproveRecurringHomesLostPerMonth { get; set; }
        [Required]
        public CalculationType.CalculationType CalculationType { get; set; }
        public Guid Id { get; set; }
    }
}
