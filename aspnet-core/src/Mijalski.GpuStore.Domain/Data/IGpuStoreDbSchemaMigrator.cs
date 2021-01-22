using System.Threading.Tasks;

namespace Mijalski.GpuStore.Data
{
    public interface IGpuStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
