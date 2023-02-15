using Acme.BookStore.WarehouseDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.IWarehouse
{
    public interface IWarehouseService: ICrudAppService
        <
         QWarehouseDto,
         Guid,
         PagedAndSortedResultRequestDto,
         CUWarehouseDto>
    {
        public Task<dynamic> Query();
    }
}
