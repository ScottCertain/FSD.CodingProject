using FSD.CodingProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FSD.CodingProject;

[DependsOn(
    typeof(CodingProjectEntityFrameworkCoreTestModule)
    )]
public class CodingProjectDomainTestModule : AbpModule
{

}
