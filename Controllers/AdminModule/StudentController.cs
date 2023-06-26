using Library.DataTbl;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers.AdminModule
    {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
        {
        private readonly IStudents iStudent;
        private readonly IDepartment iDepartment;
        public StudentController(IStudents iStudent , IDepartment iDepartment)
            {
            this.iStudent = iStudent;
            this.iDepartment = iDepartment;
            }

        // GET: api/<StudentController>
        [HttpGet]
        [Route("GetAllStudents")]
        public ActionResult<List<Students>> GetAllStudents()
            {
            return iStudent.GetAllStudents();
            }

        //Get students with department
        [HttpGet]
        [Route("GetStudentsWithDepartment")]
        public IActionResult GetStudentsWithDepartment()
            {
            var students = iStudent.GetAllStudents();

            var studentData = students.Select(s => new
                {
                Id=s.Id,
                FullName = s.FullName,
                FatherName = s.FatherName,
                Gender = s.Gender,
                RollNumber = s.RollNumber,
                Session = s.Session,
                Status=s.Status,
                EMail=s.Email,
                Password=s.Password,
                DepartmentName = iStudent.GetDepartmentName(s.DepartmentId),
                DepartmentId= s.DepartmentId
                });

            return Ok(studentData);
            }

        //GetRollNumbersByDepartment

        [HttpGet]
        [Route("GetRollNumbersByDepartmentId")]
        public IActionResult GetRollNumbersByDepartmentId(int departmentId)
            {

            List<Students> students = iStudent.GetStudentsByDepartmentId(departmentId);
            List<int> rollNumbers = students.Select(s => s.RollNumber).ToList();
            return Ok(rollNumbers);
            }


        //[HttpGet]
        //[Route("GetRollNumbersByDepartmentId")]
        //public IActionResult GetRollNumbersByDepartmentId(int departmentId)
        //    {
        //    List<Students> students = iStudent.GetStudentsByDepartmentId(departmentId);
        //    List<int> rollNumbers = students.Select(s => s.RollNumber).ToList();
        //    return Ok(rollNumbers);
        //    }

        // GET api/<StudentController>/5
        [HttpGet]
        [Route("GetStudentbyRollNumber")]
        public Students GetStudentbyRollNumber(int rollNumber)
            {
            return iStudent.GetStudentbyRollNumber(rollNumber);
            }

        // POST api/<StudentController>
        [HttpPost]
        [Route("AddStudent")]
        public Students Create(Students student)
            {
            return iStudent.AddStudent(student);
            }

        // PUT api/<StudentController>/5
        [HttpPut]
        [Route("UpdateStudent")]
        public Students Update(Students student)
            {
            return iStudent.UpdateStudent(student);
            }

        // DELETE api/<StudentController>/5
        [HttpDelete]
        [Route("DeleteStudent")]
        public void Delete(int id)
            {
            iStudent.DeleteStudent(id);
            }
        }
    }
