using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class PermissionRepository : IPermission
        {
        private readonly LibraryContext _context;

        public PermissionRepository(LibraryContext context)
            {
            _context = context;
            }
        public Permission AddPermission(Permission permission)
            {
            permission.Status = true;
            _context.permissions.Add(permission);
            _context.SaveChanges();
            return permission;
            }

        public void DeletePermission(int id)
            {
            var permission = _context.permissions.FirstOrDefault(x => x.Id == id);
            if(permission != null)
                {
                permission.Status = false;
                _context.permissions.Update(permission);
                _context.SaveChanges();
                }
           
            }

        public List<Permission> GetAllPermissions()
            {
            return _context.permissions.Where(row => row.Status == true).ToList();
            }

        public Permission GetPermissionbyId(int id)
            {
            throw new NotImplementedException();
            }

        public Permission UpdatePermission(Permission permission)
            {
            permission.Status = true;
            _context.permissions.Update(permission);
            _context.SaveChanges();
            return permission;
            }
        }
    }
