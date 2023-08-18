using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FSD.CodingProject.Data;

/* This is used if database provider does't define
 * ICodingProjectDbSchemaMigrator implementation.
 */
public class NullCodingProjectDbSchemaMigrator : ICodingProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
