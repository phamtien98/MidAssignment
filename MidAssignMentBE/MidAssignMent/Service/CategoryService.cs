using MidAssignMentBE.DTO;
using MidAssignMentBE.Interfaces;
using MidAssignMentBE.Models;

namespace MidAssignMentBE.Service
{

    public class CategoryService : ICategory
    {
        private LibraryManagementContext _dbContext;
        public CategoryService(LibraryManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddCategory(CategoryDTO category)
        {
            var item = _dbContext.Categories.Where(m=>m.Name == category.Name).FirstOrDefault();
            if(item == null)
            {
                var addCategory = _dbContext.Categories.Add(new Category
                {
                    Name = category.Name,
                    Description = category.Description,
                });
                _dbContext.SaveChanges();
            }
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

        public void EditCategory(int id, CategoryDTO category)
        {
            var item = _dbContext.Categories.Find(id);
            if(item != null)
            {
                item.Name = category.Name;
                item.Description = category.Description;    
                _dbContext.SaveChanges();
            }
        }

        public Category FindCategoryById(int id)
        {
            return _dbContext.Categories.Find(id);
        }

        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
