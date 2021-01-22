using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mijalski.GpuStore.Business
{
    public class GraphicsCard : AuditedAggregateRoot<Guid>
    {
        public GraphicsCard(string name, Manufacturer manufacturer, decimal price, string vendorName, string ramSize, 
             string ramType, DateTime releaseDate, bool doesSupportRtx = default, string memoryBus = default, int? cudaCoresCount = default)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            VendorName = vendorName;
            RamSize = ramSize;
            RamType = ramType;
            ReleaseDate = releaseDate;
            DoesSupportRtx = doesSupportRtx;
            MemoryBus = memoryBus;
            CudaCoresCount = cudaCoresCount;
        }

        // For ORM purposes only
        private GraphicsCard()
        {
        }

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