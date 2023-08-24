using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.CodingProject.Calculations
{
    public class CurrentCalculations : IRateIncreaseCalculations, ILowerPayrollRevenueCalculations, ILowerCustomerTurnoverCalculations
    {
        // IRateIncreaseCalculations
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


        // ILowerPayrollRevenueCalculations
        public decimal LowerPayrollRevenuePercent { get; set; }  // (CalculationInputs)
        public decimal ExtraGrossProfit_LPR { get; set; }
        public decimal ExtraGrossProfitSubtotal { get; set; }
        public decimal NetProfitSubtotal { get; set; }
        public decimal NetProfitPercentIncreaseSubtotal { get; set; }


        // ILowerCustomerTurnoverCalculations
        public decimal ImproveRecurringHomesLostPerMonthPercent { get; set; }
        public int NumberRecurringHomesLostPerMonth { get; set; }
        public int NumberRecurringHomesSoldPerMonth { get; set; }
        public decimal PercentRecurringHomesLostPerMonth { get; set; }
        public int FlatLineRecurringJobs { get; set; }
        public int ExtraRecurringJobsPerMonth { get; set; }
        public decimal ExtraRevenue { get; set; }
        public decimal ExtraGrossProfit { get; set; }


        // IRateIncreaseCalculations
        public decimal CalculateRevenue()
        {
            return BillRatePerJob * JobsPerMonth;
        }

        public decimal CalculateCOGS()
        {
            return Revenue * PayrollRevenuePercent;  // (PayrollRevenuePercent -> COGS Percent)
        }

        public decimal CalculateGrossProfit()
        {
            return Revenue - COGS;
        }

        public decimal CalculateGrossProfitPercent()
        {
            return 1 - PayrollRevenuePercent;  // (PayrollRevenuePercent -> COGS Percent)
        }

        public decimal CalculateExtraGrossProfit_RI()
        {
            return 0;
        }

        public decimal CalculateNetProfit()
        {
            return Revenue * PercentNetProfit;
        }

        public decimal CalculateNetProfitPercentIncrease()
        {
            return 0;
        }



        // ILowerPayrollRevenueCalculations
        public decimal CalculateExtraGrossProfit_LPR()
        {
            return 0;
        }

        public decimal CalculateExtraGrossProfitSubtotal()
        {
            return 0;
        }

        public decimal CalculateNetProfitSubtotal()
        {
            return 0;
        }

        public decimal CalculateNetProfitPercentIncreaseSubtotal()
        {
            return 0;
        }


        // ILowerCustomerTurnoverCalculations
        public decimal CalculateNumberRecurringHomesLostPerMonth()
        {
            return PercentRecurringHomesLostPerMonth * JobsPerMonth;
        }

        public decimal CalculateNumberRecurringHomesSoldPerMonth()
        {
            return NumberRecurringHomesSoldPerMonth = NumberRecurringHomesLostPerMonth;
        }

        public decimal CalculateFlatLineRecurringJobs()
        {
           return NumberRecurringHomesLostPerMonth / PercentRecurringHomesLostPerMonth;
        }

        public decimal CalculateExtraRecurringJobsPerMonth()
        {
            return 0;
        }

        public decimal CalculateExtraRevenue()
        {
            return 0;
        }

        public decimal CalculateExtraGrossProfit()
        {
            return 0;
        }
    }
}
