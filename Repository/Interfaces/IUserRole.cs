using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IUserRole
        {
        UserRole AddUserRole(UserRole userRole);
        void DeleteUserRole(int id);
        List<UserRole> GetAllUserRoles();
        UserRole GetUserRolebyId(int id);
        UserRole UpdateUserRole(UserRole userRole);
        }
    }
