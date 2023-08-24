using System;
using Volo.Abp.Application.Dtos;

namespace FSD.CodingProject.CalculationInputs
{
    public class CalculationInputDto : AuditedEntityDto<Guid>
    {
        public int JobsPerMonth { get; set; }

        public decimal PayrollRevenuePercent { get; set; }

        public decimal BillRatePerJob { get; set; }

        public decimal PercentRecurringHomesLostPerMonth { get; set; }

        public decimal PercentNetProfit { get; set; }

        public decimal PercentRateIncrease { get; set; }

        public decimal PercentExpectedJobLoss { get; set; }

        public decimal LowerPayrollRevenuePercent { get; set; }

        public decimal ImproveRecurringHomesLostPerMonthPercent { get; set; }

        public CalculationType.CalculationType CalculationType { get; set; }
    }
}
