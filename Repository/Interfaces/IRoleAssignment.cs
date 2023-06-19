using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IRoleAssignment
        {
        List<RoleAssignment> GetAllRoleAssignment();
        List<RoleAssignment> GetAllRoleAssignmentData();
        RoleAssignment AddRoleAssignment(RoleAssignment roleAssignment);
        RoleAssignment UpdateRoleAssignment(RoleAssignment roleAssignment);
        void DeleteRoleAssignment(int id);
        string GetPermissionTitle(int permissionId);
        string GetPermissionUrl(int permissionId);
        string GetUserRole(int userRoleId);
        }
    }
