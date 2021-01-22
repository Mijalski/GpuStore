using System;
using AutoMapper;
using Volo.Abp.Application.Dtos;

namespace Mijalski.GpuStore.Business
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