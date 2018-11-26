using System;
using System.Collections.Generic;
using System.Linq;
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
            IEnumerable<VideoLibrary> videolibrarys = new List<VideoLibrary>();
            try
            {
                videolibrarys = _Repository.GetVideoLibraries();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(videolibrarys);
        }

        // GET api/videolibrary/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            VideoLibrary videolibrary = new VideoLibrary();
            try
            {
                videolibrary = _Repository.GetVideoById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(videolibrary);
        }

        // POST api/videolibrary
        [HttpPost]
        public ActionResult Post([FromBody] VideoLibrary newvideolibrary)
        {
            VideoLibrary postedvideolibrary = new VideoLibrary();
            try
            {
                postedvideolibrary = _Repository.PostNewVideo(newvideolibrary);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedvideolibrary);
        }

        // PUT api/videolibrary/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] VideoLibrary updatevideolibrary)
        {
            VideoLibrary postedvideolibrary = new VideoLibrary();
            try
            {
                postedvideolibrary = _Repository.UpdateVideo(id, updatevideolibrary);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedvideolibrary);
        }

       /* // DELETE api/videolibrary/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
