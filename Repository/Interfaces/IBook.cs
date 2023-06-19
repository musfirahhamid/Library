using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IBook
        {
        Book AddBook(Book book);
        void DeleteBook(int id);
        List<Book> GetAllBooks();
        Book GetBookbyId(int id);
        Book UpdateBook(Book book);
        }
    }
