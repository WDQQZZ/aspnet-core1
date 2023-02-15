using Acme.BookStore.MESAGV;
using Acme.BookStore.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.IOrder
{
    public interface IOrderService: 
        ICrudAppService<
            OrderDto,
        Guid, 
        PagedAndSortedResultRequestDto,
        CUOrderDto>
    {
        public Task<IEnumerable<QueryConditionTwoDto>> QueryConditionTwo(DateTime? createTime,DateTime? eddTime,string? OrderTypeOne, string? orderType);

        public Task<dynamic> Show();
    }
}
