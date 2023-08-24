using System;
using System.Collections.Generic;
using System.Text;

namespace FSD.CodingProject.Calculations
{
    public interface ILowerPayrollRevenueCalculations
    {
        public decimal LowerPayrollRevenuePercent { get; set; }  // (CalculationInputs)
        public decimal PayrollRevenuePercent { get; set; }       // (CalculationInputs)
        public decimal ExtraGrossProfit_LPR { get; set; }
        public decimal ExtraGrossProfitSubtotal { get; set; }
        public decimal NetProfitSubtotal { get; set; }
        public decimal NetProfitPercentIncreaseSubtotal { get; set; }


        public decimal CalculateExtraGrossProfit_LPR();

        public decimal CalculateExtraGrossProfitSubtotal();

        public decimal CalculateNetProfitSubtotal();

        public decimal CalculateNetProfitPercentIncreaseSubtotal();
    }
}
