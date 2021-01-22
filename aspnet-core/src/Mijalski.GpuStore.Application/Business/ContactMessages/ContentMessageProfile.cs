﻿using AutoMapper;

namespace Mijalski.GpuStore.Business
{
    public class ContentMessageProfile : Profile
    {
        public ContentMessageProfile()
        {
            CreateMap<ContactMessage, ContactMessageDto>();
            CreateMap<CreateUpdateContactMessageDto, ContactMessage>();
        }
    }
}