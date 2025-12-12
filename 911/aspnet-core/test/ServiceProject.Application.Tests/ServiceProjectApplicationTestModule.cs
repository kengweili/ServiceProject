using Volo.Abp.Modularity;

namespace ServiceProject;

[DependsOn(
    typeof(ServiceProjectApplicationModule),
    typeof(ServiceProjectDomainTestModule)
)]
public class ServiceProjectApplicationTestModule : AbpModule
{

}
