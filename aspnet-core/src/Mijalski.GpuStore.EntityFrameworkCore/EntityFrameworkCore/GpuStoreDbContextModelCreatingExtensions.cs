using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Mijalski.GpuStore.EntityFrameworkCore
{
    public static class GpuStoreDbContextModelCreatingExtensions
    {
        public static void ConfigureGpuStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(GpuStoreConsts.DbTablePrefix + "YourEntities", GpuStoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}