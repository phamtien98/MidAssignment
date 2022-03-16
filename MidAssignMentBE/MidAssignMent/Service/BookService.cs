using MidAssignMentBE.DTO;
using MidAssignMentBE.Interfaces;
using MidAssignMentBE.Models;

namespace MidAssignMentBE.Service
{
    public class BookService : IBooK
    {
        private LibraryManagementContext _dbContext;
        public BookService(LibraryManagementContext dbContext)
        {
                _dbContext = dbContext;
        }
        public void AddBook(BookDTO book)
        {
            var findCategory = _dbContext.Books.Find(book.CategoryId);
            var item = _dbContext.Books.Where(m=>m.Name == book.Name).FirstOrDefault();
            if(item == null && findCategory != null)
            {
                _dbContext.Books.Add(new Book()
                {
                    Name = book.Name,
                    CategoryId= book.CategoryId,
                    Summary = book.Summary,
                    Author = book.Author,   

                });
                _dbContext.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            var item = _dbContext.Books.Find(id);
            if (item != null)
            {
                _dbContext.Books.Remove(item);
                _dbContext.SaveChanges();
            }
        }

        public void EditBook(int id, BookDTO book)
        {
            var item = _dbContext.Books.Find(id);
            if (item != null)
            {
                item.Name = book.Name;
                item.Summary = book.Summary;
                item.Author = book.Author;
                _dbContext.SaveChanges();
            }
        }

        public List<Book> GetBook()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _dbContext.Books.Find(id);
        }
    }
}
