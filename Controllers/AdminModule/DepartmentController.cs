using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
        {
        private readonly IDepartment iDepartment;
        public DepartmentController(IDepartment iDepartment)
            {
            this.iDepartment = iDepartment;
            }
        // GET: api/<DepartmentController>
        [HttpGet]
        [Route("GetAllDepartments")]
        public ActionResult<List<Department>> Get()
            {
            return iDepartment.GetAllDepartments();
            }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
            {
            return "value";
            }

        // POST api/<DepartmentController>
        [HttpPost]
        [Route("AddDepartment")]
        public Department Create(Department department)
            {
            return iDepartment.AddDepartment(department);
            }

        // PUT api/<DepartmentController>/5
        [HttpPut]
        [Route("UpdateDepartment")]
        public Department Update(Department department)
            {
            return iDepartment.UpdateDepartment(department);
            }

        // DELETE api/<DepartmentController>/5
        [HttpDelete]
        [Route("DeleteDepartment")]
        public void Delete(int id)
            {
            iDepartment.DeleteDepartment(id);
            }
        }
    }
