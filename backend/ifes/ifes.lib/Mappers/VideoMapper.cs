using AutoMapper;
using ifes.lib.domain.Catalogs;
using ifes.lib.DTOs.CatalogDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Mappers {
   public class VideoMapper {
        private IMapper _mapper;

        public VideoMapper() {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Video, VideoDto>();


            });

            _mapper = config.CreateMapper();

        }

        public List<VideoDto> MapVideosDto(IEnumerable<Video> Videos) {
            try {
                return _mapper.Map<List<VideoDto>>(Videos);
            } catch (Exception ex) {
                throw;
            }
        }

        public VideoDto MapVideoDto(Video Video) {
            try {
                return _mapper.Map<VideoDto>(Video);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}

