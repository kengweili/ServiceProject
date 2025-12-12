using Volo.Abp.Modularity;

namespace ServiceProject;

/* Inherit from this class for your domain layer tests. */
public abstract class ServiceProjectDomainTestBase<TStartupModule> : ServiceProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
