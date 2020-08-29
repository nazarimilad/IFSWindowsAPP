using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.Mappers;
using ifes.lib.Models.Catalogs.MultiMedia;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AudioController : ControllerBase
    {
        private readonly IRepository<Audio> _audiorepo;
        private readonly AudioMapper _audioMapper;

        public AudioController(IRepository<Audio> audioRepo, AudioMapper audioMapper) {
            _audiorepo = audioRepo;
            _audioMapper = audioMapper;

        }
        // GET: api/Audio
        [HttpGet]
        public IActionResult Get() {
            var allAudios = _audiorepo.GetList(x => x.Id != null).OrderBy(x => x.Name);
            var allAudiosDtos = _audioMapper.MapAudiosDto(allAudios);
            return Ok(allAudiosDtos);
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] Guid id) {
            var audio = _audiorepo.Get(x => x.Id == id);

            var audioDto = _audioMapper.MapAudioDto(audio);
            return Ok(audioDto);
        }


        // POST: api/Audio
        [HttpPost]
        public IActionResult Post([FromBody] AddAudioModel model)
        {
            Audio audio = new Audio(model);
            _audiorepo.Add(audio);
            if (_audiorepo.SaveChanges() == 0) throw new ApplicationException("failed to create Audio");
            //var BeverageDto = _beverageMapper.MapBeverageDto(Beverage);
            return Ok(audio);
        }

        // PUT: api/Audio/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
