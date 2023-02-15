using Acme.BookStore.MESAGV;
using Acme.BookStore.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.IMESAGV
{
    public interface ISystemHomePage: ICrudAppService<SystemHomePageDto,Guid,PagedAndSortedResultRequestDto,CUSystemHomePageDto>
    {
        public Task<dynamic> GetListAsyncss();
        public Task<dynamic> GetQueryCondition(string? name);

        public Task<dynamic> CreateAsyncOne(CUSystemHomePageDto input);
        public Task<dynamic> CreateAsyncTwo(CUOrderDto cUOrderDto);
    }
}
