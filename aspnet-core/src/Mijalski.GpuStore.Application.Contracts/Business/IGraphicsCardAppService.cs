﻿using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Mijalski.GpuStore.Business
{
    public interface IGraphicsCardAppService :
        ICrudAppService<
            GraphicsCardDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateGraphicsCardDto> 
    {

    }
}