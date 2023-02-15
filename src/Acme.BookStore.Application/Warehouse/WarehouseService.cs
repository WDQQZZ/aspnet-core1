using Acme.BookStore.Books;
using Acme.BookStore.IWarehouse;
using Acme.BookStore.WarehouseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Warehouse
{
    public class WarehouseService : CrudAppService
        <
            WarehouseModel,
            QWarehouseDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CUWarehouseDto
        >, IWarehouseService

    {
        IRepository<WarehouseModel, Guid> repository1;
        public WarehouseService(IRepository<WarehouseModel, Guid> repository) : base(repository)
        {
            repository1 = repository;
        }

        [HttpGet]
        public async Task<dynamic> Query()
        {
            var query = await repository1.GetQueryableAsync();
            
            return query;
        }
    }
}
