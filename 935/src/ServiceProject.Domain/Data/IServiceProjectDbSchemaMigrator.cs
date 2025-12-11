using System.Threading.Tasks;

namespace ServiceProject.Data;

public interface IServiceProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
