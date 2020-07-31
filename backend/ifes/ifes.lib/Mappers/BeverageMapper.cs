using AutoMapper;
using ifes.lib.domain.Catalogs;
using ifes.lib.DTOs.CatalogDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Mappers {
   public class BeverageMapper {
        private IMapper _mapper;
        public BeverageMapper() {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Beverage, BeverageDto>();


            });

            _mapper = config.CreateMapper();

        }

        public List<BeverageDto> MapBeveragesDto(IEnumerable<Beverage> Beverages) {
            try {
                return _mapper.Map<List<BeverageDto>>(Beverages);
            } catch (Exception ex) {
                throw;
            }
        }

        public BeverageDto MapBeverageDto(Beverage Beverage) {
            try {
                return _mapper.Map<BeverageDto>(Beverage);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}
