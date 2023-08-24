using System;
using System.Collections.Generic;
using System.Text;

namespace FSD.CodingProject.Calculations
{
    public interface IRateIncreaseCalculations
    {
        public decimal BillRatePerJob { get; set; }     //(CalculationInput)
        public int JobsPerMonth { get; set; }           //(CalculationInput)
        public decimal PayrollRevenuePercent { get; set; }   //(CalculationInput)
        public decimal PercentNetProfit { get; set; }    //(CalculationInput)
        public decimal Revenue { get; set; }
        public decimal COGS { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal GrossProfitPercent { get; set; }
        public decimal ExtraGrossProfit_RI { get; set; }
        public decimal NetProfit { get; set; }
        public decimal NetProfitPercentIncrease { get; set; }

        public decimal CalculateRevenue();

        public decimal CalculateCOGS();

        public decimal CalculateGrossProfit();

        public decimal CalculateGrossProfitPercent();

        public decimal CalculateExtraGrossProfit_RI();

        public decimal CalculateNetProfit();

        public decimal CalculateNetProfitPercentIncrease();
    }
}
