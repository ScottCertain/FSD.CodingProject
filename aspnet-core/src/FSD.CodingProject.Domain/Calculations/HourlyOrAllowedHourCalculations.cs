using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.CodingProject.Calculations
{
    public class HourlyOrAllowedHourCalculations : IRateIncreaseCalculations, ILowerPayrollRevenueCalculations, ILowerCustomerTurnoverCalculations, ITotalCalculations
    {
        // IRateIncreaseCalculations
        public decimal BillRatePerJob { get; set; }
        public decimal BillRatePerJob_HourlyOrAllowedHour { get; set; }
        public int JobsPerMonth { get; set; }
        public int JobsPerMonth_HourlyOrAllowedHour { get; set; }
        public decimal PayrollRevenuePercent { get; set; }
        public decimal PayrollRevenuePercent_HourlyOrAllowedHour { get; set; }
        public decimal PercentNetProfit { get; set; }
        public decimal Revenue { get; set; }
        public decimal Revenue_HourlyOrAllowedHour { get; set; }
        public decimal COGS { get; set; }
        public decimal COGS_HourlyOrAllowedHour { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal GrossProfit_HourlyOrAllowedHour { get; set; }
        public decimal GrossProfitPercent { get; set; }
        public decimal ExtraGrossProfit_RI { get; set; }
        public decimal ExtraGrossProfit_RI_HourlyOrAllowedHour { get; set; }
        public decimal NetProfit { get; set; }
        public decimal NetProfit_HourlyOrAllowedHour { get; set; }
        public decimal NetProfitPercentIncrease { get; set; }
        public decimal NetProfitPercentIncrease_HourlyOrAllowedHour { get; set; }
        public int PercentRateIncrease { get; private set; }
        public int PercentExpectedJobLoss { get; private set; }

        // ILowerPayrollRevenueCalculations
        public decimal LowerPayrollRevenuePercent { get; set; }
        public decimal ExtraGrossProfit_LPR { get; set; }
        public decimal ExtraGrossProfit_LPR_HourlyOrAllowedHour { get; set; }
        public decimal ExtraGrossProfitSubtotal { get; set; }
        public decimal ExtraGrossProfitSubtotal_HourlyOrAllowedHour { get; set; }
        public decimal NetProfitSubtotal { get; set; }
        public decimal NetProfitSubtotal_HourlyOrAllowedHour { get; set; }
        public decimal NetProfitPercentIncreaseSubtotal { get; set; }
        public decimal NetProfitPercentIncreaseSubtotal_HourlyOrAllowedHour { get; set; }

        //  ILowerCustomerTurnoverCalculations
        public decimal ImproveRecurringHomesLostPerMonthPercent { get; set; }
        public int NumberRecurringHomesLostPerMonth { get; set; }
        public int NumberRecurringHomesLostPerMonth_HourlyOrAllowedHour { get; set; }
        public int NumberRecurringHomesSoldPerMonth { get; set; }
        public int NumberRecurringHomesSoldPerMonth_HourlyOrAllowedHour { get; set; }
        public decimal PercentRecurringHomesLostPerMonth { get; set; }
        public decimal PercentRecurringHomesLostPerMonth_HourlyOrAllowedHour { get; set; }
        public int FlatLineRecurringJobs { get; set; }
        public int FlatLineRecurringJobs_HourlyOrAllowedHour { get; set; }
        public int ExtraRecurringJobsPerMonth { get; set; }
        public int ExtraRecurringJobsPerMonth_HourlyOrAllowedHour { get; set; }
        public decimal ExtraRevenue { get; set; }
        public decimal ExtraRevenue_HourlyOrAllowedHour { get; set; }
        public decimal ExtraGrossProfit { get; set; }
        public decimal ExtraGrossProfit_HourlyOrAllowedHour { get; set; }

        // ITotalCalculations
        public decimal TotalRevenuePerMonth { get; set; }
        public decimal TotalRevenuePerMonth_HourlyOrAllowedHour { get; set; }
        public decimal NetProfitTotalPerMonth { get; set; }
        public decimal NetProfitTotalPerMonth_HourlyOrAllowedHour { get; set; }
        public decimal NetProfitPercentIncreaseTotal { get; set; }
        public decimal NetProfitPercentIncreaseTotal_HourlyOrAllowedHour { get; set; }

        public decimal CalculateBillRatePerJob()
        {
            var BillRatePerJob_HourlyOrAllowedHour = BillRatePerJob * (1 - PercentRateIncrease);
            return BillRatePerJob_HourlyOrAllowedHour;
        }

        public decimal CalculateJobsPerMonth()
        {
            var JobsPerMonth_HourlyOrAllowedHour = JobsPerMonth * (1 - PercentExpectedJobLoss);
            return JobsPerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculateRevenue()
        {
            var Revenue_HourlyOrAllowedHour = JobsPerMonth_HourlyOrAllowedHour * BillRatePerJob_HourlyOrAllowedHour;
            return Revenue_HourlyOrAllowedHour;
        }


        public decimal CalculateCOGS()
        {
            var COGS_HourlyOrAllowedHour = Revenue_HourlyOrAllowedHour * (1 - PayrollRevenuePercent);
            return COGS_HourlyOrAllowedHour;
            ;
        }

        public decimal CalculateGrossProfit()
        {
            var GrossProfit_HourlyOrAllowedHour = Revenue_HourlyOrAllowedHour * (1 - PayrollRevenuePercent);
            return GrossProfit_HourlyOrAllowedHour;
        }

        public decimal CalculateExtraGrossProfit_RI()
        {
            var ExtraGrossProfit_RI_HourlyOrAllowedHour = GrossProfit_HourlyOrAllowedHour - GrossProfit;
            return ExtraGrossProfit_RI_HourlyOrAllowedHour;
        }

        public decimal CalculateNetProfit()
        {
            var NetProfit_HourlyOrAllowedHour = NetProfit + ExtraGrossProfit_RI;
            return NetProfit_HourlyOrAllowedHour;
        }

        public decimal CalculateNetProfitPercentIncrease()
        {
            var NetProfitPercentIncrease_HourlyOrAllowedHour = ExtraGrossProfit_RI_HourlyOrAllowedHour / NetProfit_HourlyOrAllowedHour;
            return NetProfitPercentIncrease_HourlyOrAllowedHour;
        }

        public decimal CalculatePayrollRevenuePercent()
        {
            var PayrollRevenuePercent_HourlyOrAllowedHour = Revenue_HourlyOrAllowedHour / (PayrollRevenuePercent * (1 - LowerPayrollRevenuePercent));
            return PayrollRevenuePercent_HourlyOrAllowedHour;
        }

        public decimal CalculateExtraGrossProfit_LPR()
        {
            var ExtraGrossProfit_LPR_HourlyOrAllowedHour = COGS_HourlyOrAllowedHour - PayrollRevenuePercent_HourlyOrAllowedHour;
            return ExtraGrossProfit_LPR_HourlyOrAllowedHour;
        }

        public decimal CalculateExtraGrossProfitSubtotal()
        {
            var ExtraGrossProfitSubtotal_HourlyOrAllowedHour = ExtraGrossProfit_LPR_HourlyOrAllowedHour + ExtraGrossProfit_RI_HourlyOrAllowedHour;
            return ExtraGrossProfitSubtotal_HourlyOrAllowedHour;
        }

        public decimal CalculateNetProfitSubtotal()
        {
            var NetProfitSubtotal_HourlyOrAllowedHour = ExtraGrossProfit_LPR_HourlyOrAllowedHour + NetProfit_HourlyOrAllowedHour;
            return NetProfitSubtotal_HourlyOrAllowedHour;
        }

        public decimal CalculateNetProfitPercentIncreaseSubtotal()
        {
            var NetProfitPercentIncreaseSubtotal_HourlyOrAllowedHour = ExtraGrossProfitSubtotal_HourlyOrAllowedHour / NetProfit_HourlyOrAllowedHour;
            return NetProfitPercentIncreaseSubtotal_HourlyOrAllowedHour;
        }

        public decimal CalculateNumberRecurringHomesLostPerMonth()
        {
            var NumberRecurringHomesLostPerMonth_HourlyOrAllowedHour = NumberRecurringHomesLostPerMonth * (1 - ImproveRecurringHomesLostPerMonthPercent);
            return NumberRecurringHomesLostPerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculateNumberRecurringHomesSoldPerMonth()
        {
            var NumberRecurringHomesSoldPerMonth_HourlyOrAllowedHour = NumberRecurringHomesSoldPerMonth;
            return NumberRecurringHomesSoldPerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculatePercentRecurringHomesLostPerMonth()
        {
            var PercentRecurringHomesLostPerMonth_HourlyOrAllowedHour = PercentRecurringHomesLostPerMonth * (1 - ImproveRecurringHomesLostPerMonthPercent);
            return PercentRecurringHomesLostPerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculateFlatLineRecurringJobs()
        {
            var FlatLineRecurringJobs_HourlyOrAllowedHour = NumberRecurringHomesLostPerMonth_HourlyOrAllowedHour / PercentRecurringHomesLostPerMonth_HourlyOrAllowedHour;
            return FlatLineRecurringJobs_HourlyOrAllowedHour;
        }

        public decimal CalculateExtraRecurringJobsPerMonth()
        {
            var ExtraRecurringJobsPerMonth_HourlyOrAllowedHour = FlatLineRecurringJobs - JobsPerMonth_HourlyOrAllowedHour;
            return ExtraRecurringJobsPerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculateExtraRevenue()
        {
            var ExtraRevenue_HourlyOrAllowedHour = ExtraRecurringJobsPerMonth_HourlyOrAllowedHour * BillRatePerJob_HourlyOrAllowedHour;
            return ExtraRevenue_HourlyOrAllowedHour;
        }

        public decimal CalculateExtraGrossProfit()
        {
            var ExtraGrossProfit_HourlyOrAllowedHour = ExtraRevenue_HourlyOrAllowedHour * (1 - LowerPayrollRevenuePercent);
            return ExtraGrossProfit_HourlyOrAllowedHour;
        }

        public decimal CalculateTotalRevenuePerMonth()
        {
            var TotalRevenuePerMonth_HourlyOrAllowedHour = Revenue_HourlyOrAllowedHour + ExtraRevenue_HourlyOrAllowedHour;
            return TotalRevenuePerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculateNetProfitTotalPerMonth()
        {
            var NetProfitTotalPerMonth_HourlyOrAllowedHour = ExtraGrossProfit_HourlyOrAllowedHour + NetProfitSubtotal_HourlyOrAllowedHour;
            return NetProfitTotalPerMonth_HourlyOrAllowedHour;
        }

        public decimal CalculateNetProfitPercentIncreaseTotal()
        {
            var NetProfitPercentIncreaseTotal_HourlyOrAllowedHour = (ExtraGrossProfit_HourlyOrAllowedHour + ExtraGrossProfit_LPR_HourlyOrAllowedHour + ExtraGrossProfit_RI_HourlyOrAllowedHour) / NetProfit;
            return NetProfitPercentIncreaseTotal_HourlyOrAllowedHour;
        }

        public decimal CalculateGrossProfitPercent()
        {
            throw new NotImplementedException();
        }
    }
}
