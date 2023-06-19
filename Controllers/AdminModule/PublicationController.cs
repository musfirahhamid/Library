using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
        {

        private readonly IPublication iPublications;
        public PublicationController(IPublication iPublications)
            {
            this.iPublications = iPublications;
            }
        // GET: api/<PublicationController>
        [HttpGet]
        [Route("GetAllPublication")]
        public ActionResult<List<Publications>> GetAllPublication()
            {
            return iPublications.GetAllPublication();
            }

        // GET api/<PublicationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
            {
            return "value";
            }

        // POST api/<PublicationController>
        [HttpPost]
        [Route("AddPublication")]
        public Publications Create(Publications publications)
            {
            return iPublications.AddPublication(publications);
            }

        // PUT api/<PublicationController>/5
        [HttpPut]
        [Route("UpdatePublication")]
        public Publications Update(Publications publications)
            {
            return iPublications.UpdatePublication(publications);
            }

        // DELETE api/<PublicationController>/5
        [HttpDelete]
        [Route("DeletePublication")]
        public Publications DeletePublication(int id)
            {
            return iPublications.DeletePublication(id);
            
            }
        }
    }
