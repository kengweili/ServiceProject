using ServiceProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ServiceProject.Permissions;

public class ServiceProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ServiceProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ServiceProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ServiceProjectResource>(name);
    }
}
