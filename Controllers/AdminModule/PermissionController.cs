using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
        {
        private readonly IPermission iPermission;
        public PermissionController(IPermission iPermission)
            {
            this.iPermission = iPermission;
            }

        // GET: api/<PermissionController>
        [HttpGet]
        [Route("GetAllPermissions")]
        public ActionResult<List<Permission>> GetAllPermissions()
            {
            return iPermission.GetAllPermissions();
            }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
            {
            return "value";
            }

        // POST api/<PermissionController>
        [HttpPost]
        [Route("AddPermission")]
        public Permission AddPermission(Permission permission)
            {
            return iPermission.AddPermission(permission);
            }

        // PUT api/<PermissionController>/5
        [HttpPut]
        [Route("UpdatePermission")]
        public Permission UpdatePermission(Permission permission)
            {
            return iPermission.UpdatePermission(permission);
            }

        // DELETE api/<PermissionController>/5
        [HttpDelete]
        [Route("DeletePermission")]
        public void DeletePermission(int id)
            {
            iPermission.DeletePermission(id);
            }
        }
    }
