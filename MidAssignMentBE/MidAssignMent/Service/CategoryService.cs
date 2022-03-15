using MidAssignMentFE.DTO;
using MidAssignMentFE.Interfaces;
using MidAssignMentFE.Models;

namespace MidAssignMentFE.Service
{
    public class CategoryService : ICategory
    {
        private LibraryManagementContext _dbContext;
        public CategoryService(LibraryManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category AddCategory(CategoryDTO category)
        {
            var addCategory = _dbContext.Categories.Add(new Category
            {
                CategoryName = category.CategoryName
            });
            _dbContext.SaveChanges();
            return addCategory.Entity;
        }

        public void DeleteCategory(int id)
        {
            var item = _dbContext.Categories.Find(id);
            if (item != null)
            {
                _dbContext.Categories.Remove(item);
                _dbContext.SaveChanges();
            }
        }

        public Category EditCategory(int id, CategoryDTO category)
        {
            var item = _dbContext.Categories.Find(id);
            if(item != null)
            {
                item.CategoryName = category.CategoryName;
                _dbContext.SaveChanges();
                return item;
            }
            return null;
        }

        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
