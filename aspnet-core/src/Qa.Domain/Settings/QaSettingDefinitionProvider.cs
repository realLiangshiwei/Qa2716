using Volo.Abp.Settings;

namespace Qa.Settings;

public class QaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(QaSettings.MySetting1));
    }
}
