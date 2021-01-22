using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Mijalski.GpuStore.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class GpuStoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "GpuStore";
    }
}
