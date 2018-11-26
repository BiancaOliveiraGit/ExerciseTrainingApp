using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository _Repository;

        public CategoryController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/category
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            IEnumerable<Category> Categorys = new List<Category>();
            try
            {
                Categorys = _Repository.GetCategories();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(Categorys);
        }

        // GET api/category/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Category category = new Category();
            try
            {
               category = _Repository.GetCategoryById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(category);
        }

        // POST api/category
        [HttpPost]
        public ActionResult Post([FromBody] Category newCategory)
        {
            Category postedCategory = new Category();
            try
            {
                postedCategory = _Repository.PostNewCategory(newCategory);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedCategory);
        }

        // PUT api/category/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Category updateCategory)
        {
            Category postedCategory = new Category();
            try
            {
                postedCategory = _Repository.UpdateCategory(id, updateCategory);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedCategory);
        }

        /* // DELETE api/category/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
