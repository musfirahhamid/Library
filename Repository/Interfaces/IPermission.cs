using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IPermission
        {
        Permission AddPermission(Permission permission);
        void DeletePermission(int id);
        List<Permission> GetAllPermissions();
        Permission GetPermissionbyId(int id);
        Permission UpdatePermission(Permission permission);
        }
    }
