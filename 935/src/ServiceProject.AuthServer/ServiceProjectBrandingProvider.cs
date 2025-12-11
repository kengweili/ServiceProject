using Microsoft.Extensions.Localization;
using ServiceProject.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ServiceProject;

[Dependency(ReplaceServices = true)]
public class ServiceProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ServiceProjectResource> _localizer;

    public ServiceProjectBrandingProvider(IStringLocalizer<ServiceProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
