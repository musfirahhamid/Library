using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class RoleAssignmentController : ControllerBase
        {
        private readonly IRoleAssignment iRoleAssignment;
        private readonly IPermission iPermission;
        private readonly IUserRole iUserRole;
        public RoleAssignmentController(IRoleAssignment iRoleAssignment , IPermission iPermission, IUserRole iUserRole)
            {
            this.iRoleAssignment = iRoleAssignment;
            this.iPermission = iPermission;
            this.iUserRole = iUserRole;
            }
        // GET: api/<RoleAssignmentController>
        [HttpGet]
        [Route("GetAllRoleAssignment")]
        public ActionResult<List<RoleAssignment>> GetAllRoleAssignment()
            {
            return iRoleAssignment.GetAllRoleAssignment();
            }

        // GET api/<RoleAssignmentController>/5
        [HttpGet]
        [Route("GetAllRoleAssignmentData")]
        public ActionResult GetAllRoleAssignmentData()
            {
           var roleAssignments= iRoleAssignment.GetAllRoleAssignment();
            var assignRole = roleAssignments.Select(s => new {
                Id = s.Id,
                Status = s.Status,
                pId=s.idPermission,
                uId=s.idUser,
                PermissionTitle = iRoleAssignment.GetPermissionTitle(s.idPermission),
                PermissionUrl = iRoleAssignment.GetPermissionUrl(s.idPermission),
                UserRole=iRoleAssignment.GetUserRole(s.idUser)
                });
            return Ok(assignRole);
            }

        // POST api/<RoleAssignmentController>
        [HttpPost]
        [Route("AddRoleAssignment")]
        public RoleAssignment AddRoleAssignment(RoleAssignment roleAssignment)
            {
            return iRoleAssignment.AddRoleAssignment(roleAssignment);
            }

        // PUT api/<RoleAssignmentController>/5
        [HttpPut]
        [Route("UpdateRoleAssignment")]
        public RoleAssignment UpdateRoleAssignment(RoleAssignment roleAssignment)
            {
            return iRoleAssignment.UpdateRoleAssignment(roleAssignment);
            }

        // DELETE api/<RoleAssignmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
            {
            iRoleAssignment.DeleteRoleAssignment(id);
            }
        }
    }
