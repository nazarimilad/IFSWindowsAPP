using AutoMapper;
using ifes.lib.domain.Catalogs;
using ifes.lib.DTOs.CatalogDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Mappers {
    public class FoodMapper {
        private IMapper _mapper;

        public FoodMapper() {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Food, FoodDto>();


            });

            _mapper = config.CreateMapper();

        }

        public List<FoodDto> MapFoodsDto(IEnumerable<Food> Foods) {
            try {
                return _mapper.Map<List<FoodDto>>(Foods);
            } catch (Exception ex) {
                throw;
            }
        }

        public FoodDto MapFoodDto(Food Food) {
            try {
                return _mapper.Map<FoodDto>(Food);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}
