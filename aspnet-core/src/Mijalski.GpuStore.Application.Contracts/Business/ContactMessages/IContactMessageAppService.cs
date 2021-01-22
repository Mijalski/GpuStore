using System.Threading.Tasks;
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
        Task SendMessage(string name, string email, string content);
    }
}