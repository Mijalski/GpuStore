﻿using System;
using Volo.Abp.Application.Dtos;

namespace Mijalski.GpuStore.Business.GraphicsCards
{
    public class GraphicsCardDto : AuditedEntityDto<Guid>
    {

        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string VendorName { get; set; }
        public string RamSize { get; set; }
        public string RamType { get; set; }
        public bool DoesSupportRtx { get; set; }
        public string MemoryBus { get; set; }
        public int? CudaCoresCount { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}