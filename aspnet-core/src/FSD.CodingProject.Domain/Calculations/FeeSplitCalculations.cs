using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.CodingProject.Calculations
{
    public class FeeSplitCalculations : IRateIncreaseCalculations, ILowerPayrollRevenueCalculations, ILowerCustomerTurnoverCalculations, ITotalCalculations
    {
        // IRateIncreaseCalculations
        public decimal BillRatePerJob { get; set; }
        public decimal BillRatePerJob_FeeSplit { get; set; }
        public int JobsPerMonth { get; set; }
        public int JobsPerMonth_FeeSplit { get; set; }
        public decimal PayrollRevenuePercent { get; set; }
        public decimal PayrollRevenuePercent_FeeSplit { get; set; }
        public decimal PercentNetProfit { get; set; }
        public decimal Revenue { get; set; }
        public decimal Revenue_FeeSplit { get; set; }
        public decimal COGS { get; set; }
        public decimal COGS_FeeSplit { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal GrossProfit_FeeSplit { get; set; }
        public decimal GrossProfitPercent { get; set; }
        public decimal ExtraGrossProfit_RI { get; set; }
        public decimal ExtraGrossProfit_RI_FeeSplit { get; set; }
        public decimal NetProfit { get; set; }
        public decimal NetProfit_FeeSplit { get; set; }
        public decimal NetProfitPercentIncrease { get; set; }
        public decimal NetProfitPercentIncrease_FeeSplit { get; set; }
        public int PercentRateIncrease { get; private set; }
        public int PercentExpectedJobLoss { get; private set; }

        // ILowerPayrollRevenueCalculations
        public decimal LowerPayrollRevenuePercent { get; set; }
        public decimal ExtraGrossProfit_LPR { get; set; }
        public decimal ExtraGrossProfit_LPR_FeeSplit { get; set; }
        public decimal ExtraGrossProfitSubtotal { get; set; }
        public decimal ExtraGrossProfitSubtotal_FeeSplit { get; set; }
        public decimal NetProfitSubtotal { get; set; }
        public decimal NetProfitSubtotal_FeeSplit { get; set; }
        public decimal NetProfitPercentIncreaseSubtotal { get; set; }
        public decimal NetProfitPercentIncreaseSubtotal_FeeSplit { get; set; }

        //  ILowerCustomerTurnoverCalculations
        public decimal ImproveRecurringHomesLostPerMonthPercent { get; set; }
        public int NumberRecurringHomesLostPerMonth { get; set; }
        public int NumberRecurringHomesLostPerMonth_FeeSplit { get; set; }
        public int NumberRecurringHomesSoldPerMonth { get; set; }
        public int NumberRecurringHomesSoldPerMonth_FeeSplit { get; set; }
        public decimal PercentRecurringHomesLostPerMonth { get; set; }
        public decimal PercentRecurringHomesLostPerMonth_FeeSplit { get; set; }
        public int FlatLineRecurringJobs { get; set; }
        public int FlatLineRecurringJobs_FeeSplit { get; set; }
        public int ExtraRecurringJobsPerMonth { get; set; }
        public int ExtraRecurringJobsPerMonth_FeeSplit { get; set; }
        public decimal ExtraRevenue { get; set; }
        public decimal ExtraRevenue_FeeSplit { get; set; }
        public decimal ExtraGrossProfit { get; set; }
        public decimal ExtraGrossProfit_FeeSplit { get; set; }

        // ITotalCalculations
        public decimal TotalRevenuePerMonth { get; set; }
        public decimal TotalRevenuePerMonth_FeeSplit { get; set; }
        public decimal NetProfitTotalPerMonth { get; set; }
        public decimal NetProfitTotalPerMonth_FeeSplit { get; set; }
        public decimal NetProfitPercentIncreaseTotal { get; set; }
        public decimal NetProfitPercentIncreaseTotal_FeeSplit { get; set; }

        public decimal CalculateBillRatePerJob()
        {
            var BillRatePerJob_FeeSplit = BillRatePerJob * (1 - PercentRateIncrease);
            return BillRatePerJob_FeeSplit;
        }

        public decimal CalculateJobsPerMonth()
        {
            var JobsPerMonth_FeeSplit = JobsPerMonth * (1 - PercentExpectedJobLoss);
            return JobsPerMonth_FeeSplit;
        }

        public decimal CalculateRevenue()
        {
            var Revenue_FeeSplit = JobsPerMonth_FeeSplit * BillRatePerJob_FeeSplit;
            return Revenue_FeeSplit;
        }


        public decimal CalculateCOGS()
        {
            var COGS_FeeSplit = Revenue_FeeSplit * (1 - PayrollRevenuePercent);
            return COGS_FeeSplit;
            ;
        }

        public decimal CalculateGrossProfit()
        {
            var GrossProfit_FeeSplit = Revenue_FeeSplit * (1 - PayrollRevenuePercent);
            return GrossProfit_FeeSplit;
        }

        public decimal CalculateExtraGrossProfit_RI()
        {
            var ExtraGrossProfit_RI_FeeSplit = GrossProfit_FeeSplit - GrossProfit;
            return ExtraGrossProfit_RI_FeeSplit;
        }

        public decimal CalculateNetProfit()
        {
            var NetProfit_FeeSplit = NetProfit + ExtraGrossProfit_RI;
            return NetProfit_FeeSplit;
        }

        public decimal CalculateNetProfitPercentIncrease()
        {
            var NetProfitPercentIncrease_FeeSplit = ExtraGrossProfit_RI_FeeSplit / NetProfit_FeeSplit;
            return NetProfitPercentIncrease_FeeSplit;
        }

        public decimal CalculatePayrollRevenuePercent()
        {
            var PayrollRevenuePercent_FeeSplit = Revenue_FeeSplit / (PayrollRevenuePercent * (1 - LowerPayrollRevenuePercent));
            return PayrollRevenuePercent_FeeSplit;
        }

        public decimal CalculateExtraGrossProfit_LPR()
        {
            var ExtraGrossProfit_LPR_FeeSplit = COGS_FeeSplit - PayrollRevenuePercent_FeeSplit;
            return ExtraGrossProfit_LPR_FeeSplit;
        }

        public decimal CalculateExtraGrossProfitSubtotal()
        {
            var ExtraGrossProfitSubtotal_FeeSplit = ExtraGrossProfit_LPR_FeeSplit + ExtraGrossProfit_RI_FeeSplit;
            return ExtraGrossProfitSubtotal_FeeSplit;
        }

        public decimal CalculateNetProfitSubtotal()
        {
            var NetProfitSubtotal_FeeSplit = ExtraGrossProfit_LPR_FeeSplit + NetProfit_FeeSplit;
            return NetProfitSubtotal_FeeSplit;
        }

        public decimal CalculateNetProfitPercentIncreaseSubtotal()
        {
            var NetProfitPercentIncreaseSubtotal_FeeSplit = ExtraGrossProfitSubtotal_FeeSplit / NetProfit_FeeSplit;
            return NetProfitPercentIncreaseSubtotal_FeeSplit;
        }

        public decimal CalculateNumberRecurringHomesLostPerMonth()
        {
            var NumberRecurringHomesLostPerMonth_FeeSplit = NumberRecurringHomesLostPerMonth * (1 - ImproveRecurringHomesLostPerMonthPercent);
            return NumberRecurringHomesLostPerMonth_FeeSplit;
        }

        public decimal CalculateNumberRecurringHomesSoldPerMonth()
        {
            var NumberRecurringHomesSoldPerMonth_FeeSplit = NumberRecurringHomesSoldPerMonth;
            return NumberRecurringHomesSoldPerMonth_FeeSplit;
        }

        public decimal CalculatePercentRecurringHomesLostPerMonth()
        {
            var PercentRecurringHomesLostPerMonth_FeeSplit = PercentRecurringHomesLostPerMonth * (1 - ImproveRecurringHomesLostPerMonthPercent);
            return PercentRecurringHomesLostPerMonth_FeeSplit;
        }

        public decimal CalculateFlatLineRecurringJobs()
        {
            var FlatLineRecurringJobs_FeeSplit = NumberRecurringHomesLostPerMonth_FeeSplit / PercentRecurringHomesLostPerMonth_FeeSplit;
            return FlatLineRecurringJobs_FeeSplit;
        }

        public decimal CalculateExtraRecurringJobsPerMonth()
        {
            var ExtraRecurringJobsPerMonth_FeeSplit = FlatLineRecurringJobs - JobsPerMonth_FeeSplit;
            return ExtraRecurringJobsPerMonth_FeeSplit;
        }

        public decimal CalculateExtraRevenue()
        {
            var ExtraRevenue_FeeSplit = ExtraRecurringJobsPerMonth_FeeSplit * BillRatePerJob_FeeSplit;
            return ExtraRevenue_FeeSplit;
        }

        public decimal CalculateExtraGrossProfit()
        {
            var ExtraGrossProfit_FeeSplit = ExtraRevenue_FeeSplit * (1 - LowerPayrollRevenuePercent);
            return ExtraGrossProfit_FeeSplit;
        }

        public decimal CalculateTotalRevenuePerMonth()
        {
            var TotalRevenuePerMonth_FeeSplit = Revenue_FeeSplit + ExtraRevenue_FeeSplit;
            return TotalRevenuePerMonth_FeeSplit;
        }

        public decimal CalculateNetProfitTotalPerMonth()
        {
            var NetProfitTotalPerMonth_FeeSplit = ExtraGrossProfit_FeeSplit + NetProfitSubtotal_FeeSplit;
            return NetProfitTotalPerMonth_FeeSplit;
        }

        public decimal CalculateNetProfitPercentIncreaseTotal()
        {
            var NetProfitPercentIncreaseTotal_FeeSplit = (ExtraGrossProfit_FeeSplit + ExtraGrossProfit_LPR_FeeSplit + ExtraGrossProfit_RI_FeeSplit) / NetProfit;
            return NetProfitPercentIncreaseTotal_FeeSplit;
        }

        public decimal CalculateGrossProfitPercent()
        {
            throw new NotImplementedException();
        }
    }
}
