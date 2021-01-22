using Volo.Abp.Settings;

namespace Mijalski.GpuStore.Settings
{
    public class GpuStoreSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(GpuStoreSettings.MySetting1));
        }
    }
}
