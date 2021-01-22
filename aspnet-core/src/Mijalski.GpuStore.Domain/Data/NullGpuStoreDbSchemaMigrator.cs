using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mijalski.GpuStore.Data
{
    /* This is used if database provider does't define
     * IGpuStoreDbSchemaMigrator implementation.
     */
    public class NullGpuStoreDbSchemaMigrator : IGpuStoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}