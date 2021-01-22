using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Mijalski.GpuStore.Business.ContactMessages
{
    public interface IContactMessageAppService :
        ICrudAppService<
            ContactMessageDto, 
            long, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateContactMessageDto> 
    {

    }
}