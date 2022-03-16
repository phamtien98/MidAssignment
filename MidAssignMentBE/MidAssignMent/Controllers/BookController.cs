using Microsoft.AspNetCore.Mvc;
using MidAssignMentBE.DTO;
using MidAssignMentBE.Interfaces;
using MidAssignMentBE.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MidAssignMentBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBooK _bookService;
        public BookController (IBooK bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("/get-all-book")]
        public List<Book> Get()
        {
            return _bookService.GetBook();
        }


        [HttpPost("/add-book")]
        public IActionResult Post([FromBody] BookDTO book)
        {
            var item = _bookService.GetBookById(book.CategoryId);
         
            if(item == null)
            {
                return Content("not found category");
            }
            else
            {
                _bookService.AddBook(book);
                return Content("Add book success");
            }
            return Content("Add Fail");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BookDTO book)
        {
            var item = _bookService.GetBookById(id);
            if (item != null)
            {
                _bookService.EditBook(id, book);
                return Content("Edit success");
            }
            return BadRequest("Not found");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _bookService.GetBookById(id);
            if (item != null)
            {
                _bookService.DeleteBook(id);
                return Content("Edit success");
            }
            return BadRequest("Not found");
        }
    }
}
