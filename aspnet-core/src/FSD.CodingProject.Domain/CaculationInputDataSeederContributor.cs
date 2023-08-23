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
                        PayrollRevenuePercent = 0.40,
                        BillRatePerJob = 175.00M,
                        RecurringHomesLostPerMonth = 0.05,
                        NetProfit = 0.10,
                        PercentRateIncrease = 0.10,
                        PercentExpectedJobLoss = 0.05,
                        LowerPayrollRevenuePercent = 0.05,
                        ImproveRecurringHomesLostPerMonth = 0.10,
                    },
                    autoSave: true
                );
            }
        }
    }
}
