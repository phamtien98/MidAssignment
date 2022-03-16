using MidAssignMentBE.Models;
using MidAssignMentBE.DTO;

namespace MidAssignMentBE.Interfaces
{
    public interface IBooK
    {
        List<Book> GetBook();
        void AddBook(BookDTO book);
        void EditBook(int id, BookDTO book);
        void DeleteBook(int id);
        Book GetBookById(int id);

    }
}
