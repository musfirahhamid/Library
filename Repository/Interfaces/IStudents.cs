using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IStudents
        {
        Students AddStudent(Students student);
        void DeleteStudent(int id);
        List<Students> GetAllStudents();
        Students GetStudentbyRollNumber(int rollnumber);
        Students UpdateStudent(Students student);
        //IEnumerable<Students> GetStudentsWithDepartment();
        string GetDepartmentName(int departmentId);
        List<Students> GetStudentsByDepartmentId(int departmentId);
        }
    }