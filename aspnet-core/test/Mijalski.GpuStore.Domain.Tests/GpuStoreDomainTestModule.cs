using Mijalski.GpuStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mijalski.GpuStore
{
    [DependsOn(
        typeof(GpuStoreEntityFrameworkCoreTestModule)
        )]
    public class GpuStoreDomainTestModule : AbpModule
    {

    }
}