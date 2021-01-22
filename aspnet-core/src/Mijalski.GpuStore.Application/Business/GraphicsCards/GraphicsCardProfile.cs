using AutoMapper;

namespace Mijalski.GpuStore.Business.GraphicsCards
{
    public class GraphicsCardProfile : Profile
    {
        public GraphicsCardProfile()
        {
            CreateMap<GraphicsCard, GraphicsCardDto>();
            CreateMap<CreateUpdateGraphicsCardDto, GraphicsCard>();
        }
    }
}