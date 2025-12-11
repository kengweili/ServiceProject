using ServiceProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ServiceProject.Web.Pages;

public abstract class ServiceProjectPageModel : AbpPageModel
{
    protected ServiceProjectPageModel()
    {
        LocalizationResourceType = typeof(ServiceProjectResource);
    }
}
