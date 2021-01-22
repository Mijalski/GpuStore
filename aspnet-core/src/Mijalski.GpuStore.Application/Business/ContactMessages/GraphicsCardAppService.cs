using System;
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
        public ContactMessageAppService(IRepository<ContactMessage, long> repository)
            : base(repository)
        {
            GetPolicyName = GpuStorePermissions.ContactMessages.Default;
            GetListPolicyName = GpuStorePermissions.ContactMessages.Default;
            CreatePolicyName = GpuStorePermissions.ContactMessages.Create;
            UpdatePolicyName = GpuStorePermissions.ContactMessages.Edit;
            DeletePolicyName = GpuStorePermissions.ContactMessages.Delete;
        }
    }
}