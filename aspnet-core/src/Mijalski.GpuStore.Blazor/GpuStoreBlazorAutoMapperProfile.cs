using AutoMapper;
using Mijalski.GpuStore.Business;
using Mijalski.GpuStore.Business.GraphicsCards;

namespace Mijalski.GpuStore.Blazor
{
    public class GpuStoreBlazorAutoMapperProfile : Profile
    {
        public GpuStoreBlazorAutoMapperProfile()
        {
            CreateMap<GraphicsCardDto, CreateUpdateGraphicsCardDto>();
        }
    }
}
