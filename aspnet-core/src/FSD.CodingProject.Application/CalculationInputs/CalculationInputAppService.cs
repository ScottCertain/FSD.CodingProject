using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FSD.CodingProject.CalculationInputs
{
    public class CalculationInputAppService : CrudAppService<
        CalculationInput, CalculationInputDto, Guid, PagedAndSortedResultRequestDto,
        UpdateCalculationInputDto>, ICalculationInputAppService
    {
        public CalculationInputAppService(IRepository<CalculationInput, Guid> repository) : base(repository)
        {
        }
    }
}
