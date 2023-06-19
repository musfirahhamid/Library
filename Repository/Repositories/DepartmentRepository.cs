using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class DepartmentRepository:IDepartment
        {
        private readonly LibraryContext _context;

        public DepartmentRepository(LibraryContext context)
            {
            _context = context;
            }

        public List<Department> GetAllDepartments()
            {
            return _context.departments.Where(row=>row.Status==true).ToList();
            }

       

        public Department AddDepartment(Department department)
            {
            department.Status = true;
            _context.departments.Add(department);
            _context.SaveChanges();
            return department;
            }

        public void DeleteDepartment(int id)
            {
            var department = _context.departments.FirstOrDefault(x => x.Id == id);
            if(department != null)
                {
                department.Status = false;
                _context.departments.Update(department);
                _context.SaveChanges();
                }
            }

        public Department GetDepartmentbyId(int id)
            {
            throw new NotImplementedException();
            }

        public Department UpdateDepartment(Department department)
            {
            department.Status = true;
            _context.departments.Update(department);
            _context.SaveChanges();
            return department;
            }
        }
    }
