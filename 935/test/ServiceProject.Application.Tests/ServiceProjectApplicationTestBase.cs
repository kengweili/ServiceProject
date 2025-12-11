using Volo.Abp.Modularity;

namespace ServiceProject;

public abstract class ServiceProjectApplicationTestBase<TStartupModule> : ServiceProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
