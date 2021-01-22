using System;
using System.Threading.Tasks;
using Mijalski.GpuStore.Business;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Mijalski.GpuStore
{
    public class GpuStoreTestDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<GraphicsCard, Guid> _graphicsCardRepository;

        public GpuStoreTestDataSeedContributor(IRepository<GraphicsCard, Guid> graphicsCardRepository)
        {
            _graphicsCardRepository = graphicsCardRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _graphicsCardRepository.GetCountAsync() <= 0)
            {
                await _graphicsCardRepository.InsertAsync(
                    new GraphicsCard("RTX 3060Ti", Manufacturer.Nvidia, 399, "ZOTAC", "8GB", "GDDR6", new DateTime(2020, 12, 01)),
                    autoSave: true
                );

                await _graphicsCardRepository.InsertAsync(
                    new GraphicsCard("RX 570", Manufacturer.Radeon, 159, "Gigabyte", "4GB", "GDDR5", new DateTime(2017, 10, 17)),
                    autoSave: true
                );
            }
        }
    }
}