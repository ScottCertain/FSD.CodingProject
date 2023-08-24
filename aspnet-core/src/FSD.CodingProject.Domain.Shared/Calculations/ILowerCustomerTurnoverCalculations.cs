using System;
using System.Collections.Generic;
using System.Text;

namespace FSD.CodingProject.Calculations
{
    public interface ILowerCustomerTurnoverCalculations
    {
        public decimal ImproveRecurringHomesLostPerMonthPercent { get; set; }   // (CalculationInputs)
        public int NumberRecurringHomesLostPerMonth { get; set; }
        public int NumberRecurringHomesSoldPerMonth { get; set; }
        public decimal PercentRecurringHomesLostPerMonth { get; set; }   // (CalculationInputs)
        public int FlatLineRecurringJobs { get; set; }
        public int ExtraRecurringJobsPerMonth { get; set; }
        public decimal ExtraRevenue { get; set; }
        public decimal ExtraGrossProfit { get; set; }

        public decimal CalculateNumberRecurringHomesLostPerMonth();

        public decimal CalculateNumberRecurringHomesSoldPerMonth();

        public decimal CalculateFlatLineRecurringJobs();

        public decimal CalculateExtraRecurringJobsPerMonth();

        public decimal CalculateExtraRevenue();

        public decimal CalculateExtraGrossProfit();
    }
}
