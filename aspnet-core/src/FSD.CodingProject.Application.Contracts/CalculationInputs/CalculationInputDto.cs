using System;
using Volo.Abp.Application.Dtos;

namespace FSD.CodingProject.CalculationInputs
{
    public class CalculationInputDto : AuditedEntityDto<Guid>
    {
        public int JobsPerMonth { get; set; }

        public double PayrollRevenuePercent { get; set; }

        public decimal BillRatePerJob { get; set; }

        public double RecurringHomesLostPerMonth { get; set; }

        public double NetProfit { get; set; }

        public double PercentRateIncrease { get; set; }

        public double PercentExpectedJobLoss { get; set; }

        public double LowerPayrollRevenuePercent { get; set; }

        public double ImproveRecurringHomesLostPerMonth { get; set; }

        public CalculationType.CalculationType CalculationType { get; set; }
    }
}
