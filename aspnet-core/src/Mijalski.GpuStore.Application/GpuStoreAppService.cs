using System;
using System.Collections.Generic;
using System.Text;
using Mijalski.GpuStore.Localization;
using Volo.Abp.Application.Services;

namespace Mijalski.GpuStore
{
    /* Inherit your application services from this class.
     */
    public abstract class GpuStoreAppService : ApplicationService
    {
        protected GpuStoreAppService()
        {
            LocalizationResource = typeof(GpuStoreResource);
        }
    }
}
