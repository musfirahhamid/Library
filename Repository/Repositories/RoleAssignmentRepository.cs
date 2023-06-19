using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class RoleAssignmentRepository : IRoleAssignment
        {
        private readonly LibraryContext _context;
        public RoleAssignmentRepository(LibraryContext context)
            {
            _context = context;
            }

        public RoleAssignment AddRoleAssignment(RoleAssignment roleAssignment)
            {
            roleAssignment.Status = true;
            _context.roleAssignments.Add(roleAssignment);
            _context.SaveChanges();
            return roleAssignment;
            }

        public void DeleteRoleAssignment(int id)
            {
            var roleAssignment = _context.roleAssignments.FirstOrDefault(x => x.Id == id);
            if(roleAssignment != null)
                {
                roleAssignment.Status = false;
                _context.roleAssignments.Update(roleAssignment);
                _context.SaveChanges();
                }
            }

        public List<RoleAssignment> GetAllRoleAssignment()
            {
           return _context.roleAssignments.ToList();
            }

        public List<RoleAssignment> GetAllRoleAssignmentData()
            {
            return _context.roleAssignments.ToList();
            }

        public string GetPermissionTitle(int permissionId)
            {
            return _context.permissions
              .Where(d => d.Id == permissionId && d.Status == true)
              .Select(d => d.permissionTitle)
              .FirstOrDefault();
            }

        public string GetPermissionUrl(int permissionId)
            {
            return _context.permissions
              .Where(d => d.Id == permissionId && d.Status == true)
              .Select(d => d.permissionUrl)
              .FirstOrDefault();
            }

        public string GetUserRole(int userRoleId)
            {
            return _context.userRoles
             .Where(d => d.Id == userRoleId && d.Status == true)
             .Select(d => d.RoleName)
             .FirstOrDefault();
            }

        public RoleAssignment UpdateRoleAssignment(RoleAssignment roleAssignment)
            {
            roleAssignment.Status = true;
            _context.roleAssignments.Update(roleAssignment);
            _context.SaveChanges();
            return roleAssignment;
            }
        }
    }
