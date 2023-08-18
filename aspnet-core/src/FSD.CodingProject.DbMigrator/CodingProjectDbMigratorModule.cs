using FSD.CodingProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FSD.CodingProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CodingProjectEntityFrameworkCoreModule),
    typeof(CodingProjectApplicationContractsModule)
    )]
public class CodingProjectDbMigratorModule : AbpModule
{
}
