using System;
using Mijalski.GpuStore.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Mijalski.GpuStore.Business.GraphicsCards
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
            GetPolicyName = GpuStorePermissions.GraphicsCards.Default;
            GetListPolicyName = GpuStorePermissions.GraphicsCards.Default;
            CreatePolicyName = GpuStorePermissions.GraphicsCards.Create;
            UpdatePolicyName = GpuStorePermissions.GraphicsCards.Edit;
            DeletePolicyName = GpuStorePermissions.GraphicsCards.Delete;
        }
    }
}