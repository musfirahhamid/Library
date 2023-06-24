using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class BookRepository:IBook
        {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
            {
            _context = context;
            }


        public List<Book> GetAllBooks()
            {
            return _context.books.Where(row=>row.Status==true && row.AvailableBooks>0).ToList();
            }


        public Book AddBook(Book book)
            {
            book.Status = true;
            book.AvailableBooks = book.BookQuantity;
            _context.books.Add(book);
            _context.SaveChanges();
            return book;
            }

        public Book UpdateBook(Book book)
            {
            book.Status = true;
            _context.books.Update(book);
            _context.SaveChanges();
            return book;
            }

        public void DeleteBook(int id)
            {
            var book= _context.books.FirstOrDefault(x=>x.Id==id);
            if(book != null)
                {
                book.Status = false;
                _context.books.Update(book);
                _context.SaveChanges();
                }
            }


        public Book GetBookbyId(int id)
            {
            throw new NotImplementedException();
            }

        
        }
    }
