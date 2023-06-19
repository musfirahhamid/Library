using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class IssueBookRepository : IissueBook
        {
        private readonly LibraryContext _context;
        public IssueBookRepository(LibraryContext context)
            {
            _context = context;
            }

        public IssueBook AddIssueBook(IssueBook issueBook)
            {
            issueBook.Status = true;
            _context.issueBooks.Add(issueBook);
            _context.SaveChanges();

            // Update the available book quantity in the Book table
            Book book = _context.books.FirstOrDefault(b => b.Id == issueBook.BookId);
            if(book != null)
                {
                book.AvailableBooks--;
                _context.SaveChanges();
                }

            // Update the available book quantity in the IssueBook table
            issueBook.AvailableBooks--;
            _context.SaveChanges();

            return issueBook;
            }

        public void DeleteIssueBook(int id)
            {
            var issueBook = _context.issueBooks.FirstOrDefault(x => x.Id == id);
            if(issueBook != null)
                {
                issueBook.Status = false;
                _context.SaveChanges();
                }
            }

        

        public List<IssueBook> GetAllIssueBooks()
            {
            return _context.issueBooks.Where(row => row.Status == true).ToList();
            }

        public List<IssueBook> GetAllIssuedData()
            {
            return _context.issueBooks.Where(row => row.Status == true).ToList();
            }

        

        public string GetBookName(int bookId)
            {
            return _context.books
               .Where(d => d.Id == bookId && d.Status == true)
               .Select(d => d.BookTitle)
               .FirstOrDefault();
            }

        public string GetDepartmentName(int departmentId)
            {
            return _context.departments
               .Where(d => d.Id == departmentId && d.Status == true)
               .Select(d => d.DepartmentName)
               .FirstOrDefault();
            }

        public string GetFullName(int StudentId)
            {
            return _context.students
               .Where(d => d.RollNumber == StudentId && d.Status == true)
               .Select(d => d.FullName)
               .FirstOrDefault();
            }

        public IssueBook GetIssueBookbyId(int id)
            {
            throw new NotImplementedException();
            }

        public int GetRollNumber(int studentId)
            {
            return _context.students
               .Where(d => d.RollNumber == studentId && d.Status == true)
               .Select(d => d.RollNumber)
               .FirstOrDefault();
            }

        public int GetSession(int studentId)
            {
            return _context.students
               .Where(d => d.RollNumber == studentId && d.Status == true)
               .Select(d => d.Session)
               .FirstOrDefault();
            }

        public IssueBook UpdateIssueBook(IssueBook issueBook)
            {
            issueBook.Status = true;
            _context.issueBooks.Update(issueBook);
            _context.SaveChanges();
            return issueBook;
            }
        }
    }
