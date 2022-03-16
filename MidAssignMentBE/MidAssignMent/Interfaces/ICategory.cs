using MidAssignMentBE.DTO;
using MidAssignMentBE.Models;

namespace MidAssignMentBE.Interfaces
{
    public interface ICategory
    {
        List<Category> GetCategories();
        void AddCategory(CategoryDTO category);
        void EditCategory (int id , CategoryDTO category);
        void DeleteCategory(int id);
        Category FindCategoryById(int id);
    }
}
