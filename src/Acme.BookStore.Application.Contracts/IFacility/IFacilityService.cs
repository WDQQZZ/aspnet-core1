using Acme.BookStore.Facility;
using Acme.BookStore.FacilityDTO;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.IFacility
{
    public interface IFacilityService:
        ICrudAppService
        <FacilityDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CUFacilityDto>
    {
    }
}
