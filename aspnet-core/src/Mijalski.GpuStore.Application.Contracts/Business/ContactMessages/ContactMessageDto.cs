using Volo.Abp.Application.Dtos;

namespace Mijalski.GpuStore.Business.ContactMessages
{
    public class ContactMessageDto : AuditedEntityDto<long>
    {
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Content { get; set; }
    }
}