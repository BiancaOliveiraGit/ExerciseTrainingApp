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
            var Categorys = _Repository.GetCategories();
            return Ok(Categorys);
        }

        // GET api/category/5
        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            var category = _Repository.GetCategoryById(id);
            return Ok(category);
        }

        // POST api/category
        [HttpPost]
        public ActionResult<Category> Post([FromBody] Category newCategory)
        {
            var postedCategory = _Repository.PostNewCategory(newCategory);
            return Ok(postedCategory);
        }

        // PUT api/category/5
        [HttpPut("{id}")]
        public ActionResult<Category> Put(int id, [FromBody] Category updateCategory)
        {
            var  postedCategory = _Repository.UpdateCategory(id, updateCategory);
            return Ok(postedCategory);
        }

        /* // DELETE api/category/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
