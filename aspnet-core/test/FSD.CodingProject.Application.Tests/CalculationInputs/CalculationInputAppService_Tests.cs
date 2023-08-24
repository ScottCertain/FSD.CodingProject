using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace FSD.CodingProject.CalculationInputs
{
    public class CalculationInputAppService_Tests : CodingProjectApplicationTestBase
    {
        private readonly ICalculationInputAppService _calculationInputAppService;

        public CalculationInputAppService_Tests()
        {
            _calculationInputAppService = GetRequiredService<ICalculationInputAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_CalculationInputs()
        {
            //Act
            var result = await _calculationInputAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task Should_Get_Calculation_Inputs_by_Id()
        {
            //Act
            Guid id = new Guid("2a6bee75-6ba6-3a7a-bd0d-3a0d36053cad");
            var result = await _calculationInputAppService.GetAsync(
                (await _calculationInputAppService.GetListAsync(
                    new PagedAndSortedResultRequestDto()))
                    .Items.First().Id);
            
            //Assert
            result.ShouldNotBeNull();
        }
    }
}
