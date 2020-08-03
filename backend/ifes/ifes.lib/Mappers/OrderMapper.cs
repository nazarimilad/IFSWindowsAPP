using AutoMapper;
using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using ifes.lib.DTOs.CatalogDtos;
using ifes.lib.DTOs.PlaneDtos;
using ifes.lib.DTOs.UsersDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Mappers {
   public class OrderMapper {

        private IMapper _mapper;
     public OrderMapper() {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Order, OrderDto>()
                .ForMember(dest => dest.Item, opt => opt.MapFrom(src => src.Item))
                .ForMember(dest => dest.Passenger, opt => opt.MapFrom(src => src.Passenger))

                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created));

                cfg.CreateMap<CatalogItem, CatalogItemDto>()
                .Include<Food, FoodDto>()
                .Include<Beverage, BeverageDto>()
                .Include<Audio, AudioDto>()
                .Include<Video, VideoDto>();


                cfg.CreateMap<Seat, SeatDto>();
                cfg.CreateMap<Passenger, PassengerDto>();

                cfg.CreateMap<Food, FoodDto>();
                cfg.CreateMap<Beverage, BeverageDto>();
                cfg.CreateMap<Audio, AudioDto>();
                cfg.CreateMap<Video, VideoDto>();


            });

            _mapper = config.CreateMapper();

        }

        public List<OrderDto> MapOrdersDto(IEnumerable<Order> orders) {
            try {
                return _mapper.Map<List<OrderDto>>( orders);
            } catch (Exception ex) {
                throw;
            }
        }

        public OrderDto MapOrderDto(Order order) {
            try {
                return _mapper.Map<OrderDto>(order);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}
