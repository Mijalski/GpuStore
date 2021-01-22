using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Mijalski.GpuStore.Business
{
    public class GraphicsCardAppService :
        CrudAppService<
            GraphicsCard,
            GraphicsCardDto,
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateGraphicsCardDto>,
        IGraphicsCardAppService
    {
        public GraphicsCardAppService(IRepository<GraphicsCard, Guid> repository)
            : base(repository)
        {

        }
    }
}