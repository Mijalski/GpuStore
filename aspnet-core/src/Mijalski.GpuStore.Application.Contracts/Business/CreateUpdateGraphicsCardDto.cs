using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Mijalski.GpuStore.Business
{
    public class CreateUpdateGraphicsCardDto : AuditedEntityDto<Guid>
    {

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(128)]
        public string VendorName { get; set; }

        [Required]
        [StringLength(128)]
        public string RamSize { get; set; }

        [Required]
        [StringLength(128)]
        public string RamType { get; set; }
        public bool DoesSupportRtx { get; set; }
        public string MemoryBus { get; set; }
        public int? CudaCoresCount { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}