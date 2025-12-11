using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ServiceProject.Data;

/* This is used if database provider does't define
 * IServiceProjectDbSchemaMigrator implementation.
 */
public class NullServiceProjectDbSchemaMigrator : IServiceProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
