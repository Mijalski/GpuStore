using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Mijalski.GpuStore.Business
{
    public class CreateUpdateContactMessageDto : AuditedEntityDto<long>
    {

        [Required]
        [StringLength(128)]
        public string SenderName { get; set; }
        [Required]
        [StringLength(128)]
        public string SenderEmail { get; set; }
        [Required]
        [StringLength(4098)]
        public string Content { get; set; }
    }
}