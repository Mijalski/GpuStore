using Mijalski.GpuStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Mijalski.GpuStore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(GpuStoreEntityFrameworkCoreDbMigrationsModule),
        typeof(GpuStoreApplicationContractsModule)
        )]
    public class GpuStoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
