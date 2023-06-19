using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
    {
    public class StudentRepository : IStudents
        {
        private readonly LibraryContext _context;

        public StudentRepository(LibraryContext context)
            {
            _context = context;
            }


        public List<Students> GetAllStudents()
            {
            return _context.students.Where(row => row.Status == true).ToList();
            }

        public string GetDepartmentName(int departmentId)
            {
            return _context.departments
                .Where(d => d.Id == departmentId && d.Status == true)
                .Select(d => d.DepartmentName)
                .FirstOrDefault();
            }



        public Students AddStudent(Students student)
            {
            student.Status = true;

            _context.students.Add(student);
            _context.SaveChanges();
            return student;
            }

        public Students UpdateStudent(Students student)
            {
            student.Status = true;
            _context.students.Update(student);
            _context.SaveChanges();
            return student;
            }

        public void DeleteStudent(int id)
            {
            var student = _context.students.FirstOrDefault(x => x.Id == id);
            if(student != null)
                {
                student.Status = false;
                _context.students.Update(student);
                _context.SaveChanges();
                }

            }


        public Students GetStudentbyRollNumber(int rollnumber)
            {
            var rollNumber = _context.students.FirstOrDefault(x => x.RollNumber == rollnumber);
            rollNumber.Status = true;
            return rollNumber;
            }

        public List<Students> GetStudentsByDepartmentId(int departmentId)
            {
            return _context.students
               .Where(s => s.DepartmentId == departmentId)
               .ToList();
            }

        //public List<Students> GetStudentsByDepartmentId(int departmentId)
        //    {
        //    return _context.students.Where(s => s.DepartmentId == departmentId).ToList();
        //    }
        }
    }
