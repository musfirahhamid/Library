namespace Library.DataTbl
    {
    public class IssueBook:Common
        {
            public int DepartmentId { get; set; }
           // public string FullName { get; set; }
           // public int Session { get; set; }
           public int StudentId { get; set; }
           // public int RollNumber { get; set; }
            public int BookId { get; set; }
            public DateTime IssueDate { get; set; }
            public int AvailableBooks { get; set; }
        }
    }
