using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class IssueBookController : ControllerBase
        {
        private readonly IissueBook iIssueBook;
        private readonly IStudents iStudents;
        private readonly IDepartment iDepartment;
        private readonly IBook iBook;
        public IssueBookController(IissueBook iIssueBook, IStudents iStudents , IDepartment iDepartment , IBook iBook)
            {
            this.iIssueBook = iIssueBook;
            this.iStudents = iStudents;
            this.iDepartment = iDepartment;
            this.iBook = iBook;
            }

        // GET: api/<IssueBookController>
        [HttpGet]
        [Route("GetAllIssueBooks")]
        public ActionResult<List<IssueBook>> Get()
            {
            return iIssueBook.GetAllIssueBooks();
            }

        [HttpGet]
        [Route("GetAllIssuedData")]
        public ActionResult IssueBook()
            {
            var issueBooks= iIssueBook.GetAllIssueBooks();
            var issueBookData = issueBooks.Select(s => new
                {
                Id = s.Id,
                Status=s.Status,
                IssueDate=s.IssueDate,
                DepartmentName = iIssueBook.GetDepartmentName(s.DepartmentId),
                DepartmentId = s.DepartmentId,
                StudentId=s.StudentId,
                FullName = iIssueBook.GetFullName(s.StudentId),
                RollNumber = iIssueBook.GetRollNumber(s.StudentId),
                Session= iIssueBook.GetSession(s.StudentId),
                BookId=s.BookId,
                BookName=iIssueBook.GetBookName(s.BookId)
                });
            return Ok(issueBookData);
            }

       

        // POST api/<IssueBookController>
        [HttpPost]
        [Route("AddIssueBook")]
        public IssueBook Create(IssueBook issueBook)
            {
            return iIssueBook.AddIssueBook(issueBook);
            }

        // PUT api/<IssueBookController>/5
        [HttpPut]
        [Route("UpdateIssueBook")]
        public IssueBook Put(IssueBook issueBook)
            {
            return iIssueBook.UpdateIssueBook(issueBook);
            }

        // DELETE api/<IssueBookController>/5
        [HttpDelete]
        [Route("DeleteIssueBook")]
        public void Delete(int id)
            {
            iIssueBook.DeleteIssueBook(id);
            }
        }
    }
