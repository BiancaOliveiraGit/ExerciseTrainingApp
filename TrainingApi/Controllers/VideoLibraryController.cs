
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoLibraryController : ControllerBase
    {
        private readonly IRepository _Repository;

        public VideoLibraryController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/videolibrary
        [HttpGet]
        public ActionResult<IEnumerable<VideoLibrary>> Get()
        {
            var videolibrarys = _Repository.GetVideoLibraries();
            return Ok(videolibrarys);
        }

        // GET api/videolibrary/5
        [HttpGet("{id}")]
        public ActionResult<VideoLibrary> Get(int id)
        {
            var videolibrary = _Repository.GetVideoById(id);
            return Ok(videolibrary);
        }

        // POST api/videolibrary
        [HttpPost]
        public ActionResult<VideoLibrary> Post([FromBody] VideoLibrary newvideolibrary)
        {
            var  postedvideolibrary = _Repository.PostNewVideo(newvideolibrary);
            return Ok(postedvideolibrary);
        }

        // PUT api/videolibrary/5
        [HttpPut("{id}")]
        public ActionResult<VideoLibrary> Put(int id, [FromBody] VideoLibrary updatevideolibrary)
        {
            var  postedvideolibrary = _Repository.UpdateVideo(id, updatevideolibrary);
            return Ok(postedvideolibrary);
        }

       /* // DELETE api/videolibrary/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
