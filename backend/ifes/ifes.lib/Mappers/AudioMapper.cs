using AutoMapper;
using ifes.lib.domain.Catalogs;
using ifes.lib.DTOs.CatalogDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Mappers {
   public class AudioMapper {
        private IMapper _mapper;

        public AudioMapper() {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Audio, AudioDto>();


            });

            _mapper = config.CreateMapper();

        }

        public List<AudioDto> MapAudiosDto(IEnumerable<Audio> Audios) {
            try {
                return _mapper.Map<List<AudioDto>>(Audios);
            } catch (Exception ex) {
                throw;
            }
        }

        public AudioDto MapAudioDto(Audio Audio) {
            try {
                return _mapper.Map<AudioDto>(Audio);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}

