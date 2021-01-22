using System;
using AutoMapper;
using Volo.Abp.Application.Dtos;

namespace Mijalski.GpuStore.Business
{
    public class GraphicsCardToGraphicsCardDtoProfile : Profile
    {
        public GraphicsCardToGraphicsCardDtoProfile()
        {
            CreateMap<GraphicsCard, GraphicsCardDto>();
            CreateMap<CreateUpdateGraphicsCardDto, GraphicsCard>();
        }
    }
}