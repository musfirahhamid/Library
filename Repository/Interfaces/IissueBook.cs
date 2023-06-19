using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IissueBook
        {
        IssueBook AddIssueBook(IssueBook issueBook);
        void DeleteIssueBook(int id);
        List<IssueBook> GetAllIssueBooks();
        IssueBook GetIssueBookbyId(int id);
        IssueBook UpdateIssueBook(IssueBook issueBook);
        string GetDepartmentName(int departmentId);
        int GetRollNumber(int studentId);
        string GetFullName(int studentId);
        int GetSession(int studentId);
        string GetBookName(int bookId);
        List<IssueBook> GetAllIssuedData();
        }
    }
