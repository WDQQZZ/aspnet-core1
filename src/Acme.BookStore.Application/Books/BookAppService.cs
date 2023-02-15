using Acme.BookStore.IBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity //实体类
            BookDto, //Used to show books //用于展示的实体类
            Guid, //Primary key of the book entity //主键
            PagedAndSortedResultRequestDto, //Used for paging/sorting //翻译：用于分页/排序
            CreateUpdateBookDto>, //Used to create/update a book //用于创建/更新的实体类
        IBookAppService //implement the IBookAppService //实现IBookAppService接口
    {
        IRepository<Book, Guid> _repository;

        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {
            _repository = repository;
        }

        //GetQueryableAsync显示所有书籍
        public dynamic GetListAsyncss()
        {
            //查询
            var query = _repository.GetQueryableAsync();
            //排序
            //query = query.OrderByIf<Book>(x => x.Name);
            //分页
            //var list = query.Skip(0).Take(10).ToList();
            return query;
        }
    }
}
