using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
        {
        private readonly IUserRole iUserRole;
        public UserRoleController(IUserRole iUserRole)
            {
            this.iUserRole = iUserRole;
            }
        // GET: api/<UserRoleController>
        [HttpGet]
        [Route("GetAllUserRoles")]
        public ActionResult<List<UserRole>> GetAllUserRoles()
            {
            return iUserRole.GetAllUserRoles();
            }

        // GET api/<UserRoleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
            {
            return "value";
            }

        // POST api/<UserRoleController>
        [HttpPost]
        [Route("AddUserRole")]
        public UserRole AddUserRole(UserRole user)
            {
            return iUserRole.AddUserRole(user);
            }

        // PUT api/<UserRoleController>/5
        [HttpPut]
        [Route("UpdateUserRole")]
        public UserRole UpdateUserRole(UserRole user)
            {
            return iUserRole.UpdateUserRole(user);
            }

        // DELETE api/<UserRoleController>/5
        [HttpDelete]
        [Route("DeleteUserRole")]
        public void Delete(int id)
            {
            iUserRole.DeleteUserRole(id);
            }
        }
    }
