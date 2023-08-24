using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FSD.CodingProject.CalculationInputs
{
    public class CalculationInputAppService : CrudAppService<
        CalculationInput, 
        CalculationInputDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        UpdateCalculationInputDto>, 
        ICalculationInputAppService
    {
        public CalculationInputAppService(IRepository<CalculationInput, Guid> repository) : base(repository)
        {
        }

        public override async Task<CalculationInputDto> UpdateAsync(Guid id, UpdateCalculationInputDto input)
        {
            // You can place a breakpoint here to debug the method
            return await base.UpdateAsync(id, input);
        }
    }
}
