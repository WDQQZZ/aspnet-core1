using Acme.BookStore.IOrder;
using Acme.BookStore.MESAGV;
using Microsoft.AspNetCore.Mvc;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Order
{
    public class OrderService : 
        CrudAppService<
            OrderModel,
            OrderDto,
            Guid, 
            PagedAndSortedResultRequestDto,
            CUOrderDto>, IOrderService
    {
         IRepository<OrderModel, Guid> repository1;
         IRepository<SystemHomePageModel, Guid> repository2;
        public OrderService(IRepository<SystemHomePageModel, Guid> Repository3,IRepository<OrderModel, Guid> repository) : base(repository)
        {
            repository1 = repository;
            repository2 = Repository3;
        }

        

        [HttpGet]
        public async Task<IEnumerable<QueryConditionTwoDto>> QueryConditionTwo(DateTime? createTime, DateTime? eddTime, string? OrderTypeOne, string? orderType)
        {
            var query = from a in await repository1.GetListAsync()
                        join b in await repository2.GetListAsync() on a.orderNumber equals b.orderId
                        select new QueryConditionTwoDto
                        {
                            orderNumber=a.orderNumber,
                            createOrderTime=a.createOrderTime.ToString("yyyy-MM-dd"),
                            orderType=a.orderType,
                            orderNum=b.OrderNum,
                            accomplishNumber=a.accomplishNumber,
                            orderType1=b.OrderType,
                            feedingType=b.FeedingType,
                            blankingType=b.BlankingType,
                            trayParameter= b.TrayParameter,
                            createOrderTimedate=a.createOrderTime
                        };

            if (!string.IsNullOrEmpty(OrderTypeOne))
            {
                query = query.Where(x => x.orderType1.Contains(OrderTypeOne));
            }

            if (!string.IsNullOrEmpty(orderType))
            {
                query = query.Where(x => x.orderType.Contains(orderType));
            }

            if (createTime != null && eddTime != null)
            {
                query = query.Where(x => x.createOrderTimedate.Date >= createTime && x.createOrderTimedate.Date <= eddTime);
            }

            return query;
        }
        [HttpGet]
        public async Task<dynamic> Show()
        {
            var query = from a in await repository2.GetQueryableAsync()
                        select a;

            return query;
        }
    }
}
