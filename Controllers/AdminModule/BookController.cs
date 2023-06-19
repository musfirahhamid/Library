using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
        {
        private readonly IBook iBook;
        public BookController(IBook iBook)
            {
            this.iBook = iBook;
            }

        // GET: api/<BookController>
        [HttpGet]
        [Route("GetAllBooks")]
        public ActionResult<List<Book>> GetAllBooks()
            {
            return iBook.GetAllBooks();
            }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
            {
            return "value";
            }

        // POST api/<BookController>
        [HttpPost]
        [Route("AddBook")]
        public Book Create(Book book)
            {
            return iBook.AddBook(book);
            }

        // PUT api/<BookController>/5
        [HttpPut]
        [Route("UpdateBook")]
        public Book Update(Book book)
            {
            return iBook.UpdateBook(book);
            }

        // DELETE api/<BookController>/5
        [HttpDelete]
        [Route("DeleteBook")]
        public void Delete(int id)
            {
            iBook.DeleteBook(id);
            }
        }
    }
