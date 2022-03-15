using MidAssignMentFE.DTO;
using MidAssignMentFE.Models;

namespace MidAssignMentFE.Interfaces
{
    public interface ICategory
    {
        List<Category> GetCategories();
        Category AddCategory(CategoryDTO category);
        Category EditCategory (int id , CategoryDTO category);
        void DeleteCategory(int id);
    }
}
