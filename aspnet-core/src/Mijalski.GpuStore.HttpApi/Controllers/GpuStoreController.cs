using Mijalski.GpuStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mijalski.GpuStore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class GpuStoreController : AbpController
    {
        protected GpuStoreController()
        {
            LocalizationResource = typeof(GpuStoreResource);
        }
    }
}