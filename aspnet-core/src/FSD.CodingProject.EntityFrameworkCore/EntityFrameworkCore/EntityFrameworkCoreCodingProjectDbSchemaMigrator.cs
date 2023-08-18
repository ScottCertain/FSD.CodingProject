using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FSD.CodingProject.Data;
using Volo.Abp.DependencyInjection;

namespace FSD.CodingProject.EntityFrameworkCore;

public class EntityFrameworkCoreCodingProjectDbSchemaMigrator
    : ICodingProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCodingProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CodingProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CodingProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
