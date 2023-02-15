using Acme.BookStore.FacilityDTO;
using Acme.BookStore.IFacility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Facility
{
    public class FacilityService :
        CrudAppService<
            FacilityModel,
            FacilityDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CUFacilityDto>, IFacilityService
    {
        IRepository<FacilityModel, Guid> repository1;
        public FacilityService(IRepository<FacilityModel, Guid> repository) : base(repository)
        {
            repository1 = repository;
        }
    }
}
