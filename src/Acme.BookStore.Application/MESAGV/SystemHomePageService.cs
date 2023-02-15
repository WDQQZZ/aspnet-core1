using Acme.BookStore.Books;
using Acme.BookStore.IMESAGV;
using Acme.BookStore.Order;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.MESAGV
{
    public class SystemHomePageService : CrudAppService<SystemHomePageModel, SystemHomePageDto, Guid, PagedAndSortedResultRequestDto, CUSystemHomePageDto>, ISystemHomePage
    {
        IRepository<SystemHomePageModel, Guid> repository1;
        IRepository<OrderModel, Guid> repository2;
        public SystemHomePageService(IRepository<SystemHomePageModel, Guid> repository, IRepository<OrderModel, Guid> repository3) : base(repository)
        {
            repository1 = repository;
            repository2 = repository3;
        }
        
        public async Task<dynamic> GetListAsyncss()
        {
            //查询
            var query = from a in await repository1.GetQueryableAsync()
                        select a;
            //排序
            //query = query.OrderByIf<Book>(x => x.Name);
            //分页
            //var list = query.Skip(0).Take(10).ToList();
            return query;
        }

        public async Task<dynamic> GetQueryCondition(string? name)
        {
            //查询
            var query = await repository1.GetQueryableAsync();

            var show = query.Where(x => x.OrderType.Contains(name));
            //排序
            //query = query.OrderByIf<Book>(x => x.Name);
            //分页
            //var list = query.Skip(0).Take(10).ToList();
            return show;
        }

        //添加
        public async Task<dynamic> CreateAsyncOne(CUSystemHomePageDto input)
        {
            var entity = ObjectMapper.Map<CUSystemHomePageDto, SystemHomePageModel>(input);
            //var result = await this.CreateAsync(input);
           var result = await repository1.InsertAsync(entity);
           
            CUOrderDto cUOrderDto = new CUOrderDto();

            //OrderModel orderModel = new OrderModel();

            cUOrderDto.orderNumber = result.Id.ToString();
            var xx=await this.CreateAsyncTwo(cUOrderDto);
            return 1;
        }

        public async Task<dynamic> CreateAsyncTwo(CUOrderDto cUOrderDto)
        {
            var entity = ObjectMapper.Map<CUOrderDto, OrderModel>(cUOrderDto);
            var result = await repository2.InsertAsync(entity);
            return 1;
        }

       
    }
}
