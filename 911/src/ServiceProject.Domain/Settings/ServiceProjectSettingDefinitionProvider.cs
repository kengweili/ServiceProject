using Volo.Abp.Settings;

namespace ServiceProject.Settings;

public class ServiceProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ServiceProjectSettings.MySetting1));
    }
}
