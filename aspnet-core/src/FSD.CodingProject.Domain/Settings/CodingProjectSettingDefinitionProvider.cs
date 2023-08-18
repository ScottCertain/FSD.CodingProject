using Volo.Abp.Settings;

namespace FSD.CodingProject.Settings;

public class CodingProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CodingProjectSettings.MySetting1));
    }
}
