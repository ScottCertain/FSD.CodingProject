using Volo.Abp.Modularity;

namespace FSD.CodingProject;

[DependsOn(
    typeof(CodingProjectApplicationModule),
    typeof(CodingProjectDomainTestModule)
    )]
public class CodingProjectApplicationTestModule : AbpModule
{

}
