using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public Category GetCategoryById(int id)
        {
            try
            {
                var item = _appDbContext.Categories.Where(w => w.CategoryId == id)
                                        .Select(s => s).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            try
            {
                var list = _appDbContext.Categories.Select(s => s).ToList();
                return list;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public Category PostNewCategory(Category newCategory)
        {
            try
            {
                //check that Category doesn't exist
                var exists = _appDbContext.Categories.Where(w => w.Name == newCategory.Name)
                                                  .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception(string.Format("Category {0} already exists", newCategory.Name));

                var item = _appDbContext.Add(newCategory);
                item.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var isOk = _appDbContext.SaveChanges();

                return item.Entity;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public Category UpdateCategory(int id, Category updateCategory)
        {
            try
            {
                //check that Category exists
                var existingCategory = _appDbContext.Categories.Where(w => w.CategoryId == updateCategory.CategoryId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingCategory != null)
                    throw new Exception(string.Format("CategoryID {0},- {1} Doesn't Exist in system", updateCategory.CategoryId, updateCategory.Name));

                //update Category
                existingCategory.Name = updateCategory.Name;
     
                var isOk = _appDbContext.SaveChanges();

                return existingCategory;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }
    }
}
