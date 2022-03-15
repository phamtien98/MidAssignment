using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidAssignMentFE.DTO;
using MidAssignMentFE.Interfaces;
using MidAssignMentFE.Models;

namespace MidAssignMentFE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet("/get-all-category")]
        public List<Category> GetAllCategory()
        {
            return _category.GetCategories();
        }

        [HttpPost("/add-new-category")]
        public Category Add( [FromBody] CategoryDTO category)
        {
            return _category.AddCategory(category);
        }

        [HttpPut("/edit-category")]
        public Category Add(int id ,[FromBody] CategoryDTO category)
        {
            return _category.EditCategory(id,category);
        }
        
        [HttpDelete("/delete-category")]
        public void Delete(int id)
        {
            _category.DeleteCategory(id);
        }
    }
}
