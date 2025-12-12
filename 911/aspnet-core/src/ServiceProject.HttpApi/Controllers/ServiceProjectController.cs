using ServiceProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ServiceProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ServiceProjectController : AbpControllerBase
{
    protected ServiceProjectController()
    {
        LocalizationResource = typeof(ServiceProjectResource);
    }
}
