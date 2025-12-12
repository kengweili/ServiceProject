using System;
using System.Collections.Generic;
using System.Text;
using ServiceProject.Localization;
using Volo.Abp.Application.Services;

namespace ServiceProject;

/* Inherit your application services from this class.
 */
public abstract class ServiceProjectAppService : ApplicationService
{
    protected ServiceProjectAppService()
    {
        LocalizationResource = typeof(ServiceProjectResource);
    }
}
