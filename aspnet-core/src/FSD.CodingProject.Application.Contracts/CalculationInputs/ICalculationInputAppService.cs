using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSD.CodingProject.CalculationInputs
{
    public interface ICalculationInputAppService :
        ICrudAppService<
            CalculationInputDto,
            Guid,
            PagedAndSortedResultRequestDto,
            UpdateCalculationInputDto>
    {
        
    }
}
