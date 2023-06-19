using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class UserRoleRepository : IUserRole
        {
        private readonly LibraryContext _context;

        public UserRoleRepository(LibraryContext context)
            {
            _context = context;
            }
        public UserRole AddUserRole(UserRole userRole)
            {
            userRole.Status = true;
            _context.userRoles.Add(userRole);
            _context.SaveChanges();
            return userRole;
            }

        public void DeleteUserRole(int id)
            {
            var userRole = _context.userRoles.FirstOrDefault(x=>x.Id==id);
            if(userRole != null)
                {
                userRole.Status = false;
                _context.userRoles.Update(userRole);
                _context.SaveChanges();
                }
            }

        public List<UserRole> GetAllUserRoles()
            {
            return _context.userRoles.Where(row => row.Status == true).ToList();
            }

        public UserRole GetUserRolebyId(int id)
            {
            throw new NotImplementedException();
            }

        public UserRole UpdateUserRole(UserRole userRole)
            {
            userRole.Status = true;
            _context.userRoles.Update(userRole);
            _context.SaveChanges();
            return userRole;
            }
        }
    }
