using System;
using System.Threading.Tasks;
using Mijalski.GpuStore.Business.ContactMessages;
using Mijalski.GpuStore.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Mijalski.GpuStore.Business.ContactMessages
{
    public class ContactMessageAppService :
        CrudAppService<
            ContactMessage,
            ContactMessageDto,
            long, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateContactMessageDto>,
        IContactMessageAppService
    {
        private readonly IRepository<ContactMessage, long> _contactMessagesRepository;

        public ContactMessageAppService(IRepository<ContactMessage, long> repository, 
            IRepository<ContactMessage, long> contactMessagesRepository)
            : base(repository)
        {
            _contactMessagesRepository = contactMessagesRepository;
            GetPolicyName = GpuStorePermissions.ContactMessages.Default;
            GetListPolicyName = GpuStorePermissions.ContactMessages.Default;
            CreatePolicyName = GpuStorePermissions.ContactMessages.Create;
            UpdatePolicyName = GpuStorePermissions.ContactMessages.Edit;
            DeletePolicyName = GpuStorePermissions.ContactMessages.Delete;
        }

        public async Task SendMessage(string name, string email, string content)
        {
            await _contactMessagesRepository.InsertAsync(new ContactMessage
            {
                SenderName = name,
                SenderEmail = email,
                Content = content
            });
        }
    }
}