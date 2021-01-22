using Volo.Abp.Domain.Entities.Auditing;

namespace Mijalski.GpuStore.Business
{
    public class ContactMessage : AuditedAggregateRoot<long>
    {
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Content { get; set; }
    }
}