using Acme.BookStore.Books;
using Acme.BookStore.Facility;
using Acme.BookStore.FacilityDTO;
using Acme.BookStore.MESAGV;
using Acme.BookStore.Order;
using Acme.BookStore.Warehouse;
using Acme.BookStore.WarehouseDto;
using AutoMapper;

namespace Acme.BookStore;
//Profile是用来配置映射关系的
public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book,BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<SystemHomePageModel, SystemHomePageDto>();
        CreateMap<CUSystemHomePageDto, SystemHomePageModel>();

        CreateMap<OrderModel, OrderDto>();
        CreateMap<CUOrderDto, OrderModel>();

        CreateMap<WarehouseModel, QWarehouseDto>();
        CreateMap<CUWarehouseDto, WarehouseModel>();

        CreateMap<FacilityModel, FacilityDto>();
        CreateMap<CUFacilityDto, FacilityModel>();
    }
}
