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
                    new GraphicsCard
                    {
                        Name = "1984",
                        Type = BookType.Dystopia,
                        PublishDate = new DateTime(1949, 6, 8),
                        Price = 19.84f
                    },
                    autoSave: true
                );

                await _graphicsCardRepository.InsertAsync(
                    new Book
                    {
                        Name = "The Hitchhiker's Guide to the Galaxy",
                        Type = BookType.ScienceFiction,
                        PublishDate = new DateTime(1995, 9, 27),
                        Price = 42.0f
                    },
                    autoSave: true
                );
            }
        }
    }
}