using ServiceProject.Samples;
using Xunit;

namespace ServiceProject.EntityFrameworkCore.Applications;

[Collection(ServiceProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ServiceProjectEntityFrameworkCoreTestModule>
{

}
