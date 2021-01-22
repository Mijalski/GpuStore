using Microsoft.EntityFrameworkCore;
using Mijalski.GpuStore.Business;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Mijalski.GpuStore.EntityFrameworkCore
{
    public static class GpuStoreDbContextModelCreatingExtensions
    {
        public static void ConfigureGpuStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<GraphicsCard>(b =>
            {
                b.ToTable(GpuStoreConsts.DbTablePrefix + "GraphicsCards", GpuStoreConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(_ => _.Name).IsRequired().HasMaxLength(128);
                b.Property(_ => _.RamSize).HasMaxLength(128);
                b.Property(_ => _.RamType).HasMaxLength(128);
                b.Property(_ => _.VendorName).HasMaxLength(128);
            });
        }
    }
}