using ServiceProject.Samples;
using Xunit;

namespace ServiceProject.EntityFrameworkCore.Domains;

[Collection(ServiceProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ServiceProjectEntityFrameworkCoreTestModule>
{

}
