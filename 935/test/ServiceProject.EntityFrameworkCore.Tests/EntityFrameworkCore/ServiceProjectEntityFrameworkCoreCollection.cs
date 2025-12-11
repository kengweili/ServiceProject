using Xunit;

namespace ServiceProject.EntityFrameworkCore;

[CollectionDefinition(ServiceProjectTestConsts.CollectionDefinitionName)]
public class ServiceProjectEntityFrameworkCoreCollection : ICollectionFixture<ServiceProjectEntityFrameworkCoreFixture>
{

}
