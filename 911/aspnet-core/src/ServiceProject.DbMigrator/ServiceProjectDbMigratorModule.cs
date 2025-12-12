using ServiceProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ServiceProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ServiceProjectEntityFrameworkCoreModule),
    typeof(ServiceProjectApplicationContractsModule)
    )]
public class ServiceProjectDbMigratorModule : AbpModule
{
}
