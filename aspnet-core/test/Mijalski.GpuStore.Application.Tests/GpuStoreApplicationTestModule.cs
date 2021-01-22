using Volo.Abp.Modularity;

namespace Mijalski.GpuStore
{
    [DependsOn(
        typeof(GpuStoreApplicationModule),
        typeof(GpuStoreDomainTestModule)
        )]
    public class GpuStoreApplicationTestModule : AbpModule
    {

    }
}