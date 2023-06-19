using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IDepartment
        {
        Department AddDepartment(Department department);
        void DeleteDepartment(int id);
        List<Department> GetAllDepartments();
        Department GetDepartmentbyId(int id);
        Department UpdateDepartment(Department department);
        
        }
    }
