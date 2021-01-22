using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Mijalski.GpuStore.EntityFrameworkCore
{
    [DependsOn(
        typeof(GpuStoreEntityFrameworkCoreModule)
        )]
    public class GpuStoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GpuStoreMigrationsDbContext>();
        }
    }
}
