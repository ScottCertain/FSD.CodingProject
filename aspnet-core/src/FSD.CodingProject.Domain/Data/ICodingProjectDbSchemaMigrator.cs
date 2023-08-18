using System.Threading.Tasks;

namespace FSD.CodingProject.Data;

public interface ICodingProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
