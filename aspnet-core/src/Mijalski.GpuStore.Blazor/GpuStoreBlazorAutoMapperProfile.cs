using AutoMapper;
using Mijalski.GpuStore.Business;

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
