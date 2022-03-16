using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidAssignMentBE.DTO;
using MidAssignMentBE.Interfaces;
using MidAssignMentBE.Models;

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
        public IActionResult Add( [FromBody] CategoryDTO category)
        {
            if(ModelState.IsValid)
            {
                _category.AddCategory(category);
                return Content("Add Successfully");
            }
            return Content("Fail");
        }

        [HttpPut("/edit-category")]
        public IActionResult Edit(int id ,[FromBody] CategoryDTO category)
        {
            var item = _category.FindCategoryById(id);
            if(item != null)
            {
                _category.EditCategory(id, category);
                return Ok();
            }
            return BadRequest("Not found category!");
             
        }
        
        [HttpDelete("/delete-category")]
        public IActionResult Delete(int id)
        {
            var item = _category.FindCategoryById(id);
            if (item != null)
            {
                _category.DeleteCategory(id);
                return Content("Delete Success");
            }
            return BadRequest("Not found category!");


        }
    }
}
