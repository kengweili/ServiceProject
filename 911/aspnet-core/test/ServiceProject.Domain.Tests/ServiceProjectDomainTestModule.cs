using Volo.Abp.Modularity;

namespace ServiceProject;

[DependsOn(
    typeof(ServiceProjectDomainModule),
    typeof(ServiceProjectTestBaseModule)
)]
public class ServiceProjectDomainTestModule : AbpModule
{

}
