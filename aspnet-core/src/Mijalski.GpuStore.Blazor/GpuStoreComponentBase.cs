using Mijalski.GpuStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Mijalski.GpuStore.Blazor
{
    public abstract class GpuStoreComponentBase : AbpComponentBase
    {
        protected GpuStoreComponentBase()
        {
            LocalizationResource = typeof(GpuStoreResource);
        }
    }
}
