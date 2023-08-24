using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using FSD.CodingProject.CalculationInputs;

namespace FSD.CodingProject
{
    public class CalculationInputDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<CalculationInput, Guid> _calculationInputRepository;

        public CalculationInputDataSeederContributor(IRepository<CalculationInput, Guid> calculationInputRepository)
        {
            _calculationInputRepository = calculationInputRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _calculationInputRepository.GetCountAsync() <= 0)
            {
                await _calculationInputRepository.InsertAsync(
                    new CalculationInput
                    {
                        JobsPerMonth = 500,
                        PayrollRevenuePercent = 0.40M,
                        BillRatePerJob = 175.00M,
                        PercentRecurringHomesLostPerMonth = 0.05M,
                        PercentNetProfit = 0.10M,
                        PercentRateIncrease = 0.10M,
                        PercentExpectedJobLoss = 0.05M,
                        LowerPayrollRevenuePercent = 0.05M,
                        ImproveRecurringHomesLostPerMonthPercent = 0.10M,
                    },
                    autoSave: true
                );
            }
        }
    }
}
