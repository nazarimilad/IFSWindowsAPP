using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.Mappers;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IRepository<Video> _videorepo;
        private readonly VideoMapper _videoMapper;

        public VideoController(IRepository<Video> videoRepo, VideoMapper videoMapper) {
            _videorepo = videoRepo;
            _videoMapper = videoMapper;

        }
        // GET: api/Video
        [HttpGet]
        public IActionResult Get() {
            var allVideos = _videorepo.GetList(x => x.Id != null);
            var allVideosDtos = _videoMapper.MapVideosDto(allVideos);
            return Ok(allVideosDtos);
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] Guid id) {
            var video = _videorepo.Get(x => x.Id == id);
            var videoDto = _videoMapper.MapVideoDto(video);
            return Ok(videoDto);
        }

        // POST: api/Video
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Video/5
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
