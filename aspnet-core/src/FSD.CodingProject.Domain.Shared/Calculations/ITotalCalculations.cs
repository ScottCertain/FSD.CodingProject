using System;
using System.Collections.Generic;
using System.Text;

namespace FSD.CodingProject.Calculations
{
    public interface ITotalCalculations
    {
        public decimal TotalRevenuePerMonth { get; set; }
        public decimal NetProfitTotalPerMonth { get; set; }
        public decimal NetProfitPercentIncreaseTotal { get; set; }

        public decimal CalculateTotalRevenuePerMonth();

        public decimal CalculateNetProfitTotalPerMonth();

        public decimal CalculateNetProfitPercentIncreaseTotal();
    }
}
