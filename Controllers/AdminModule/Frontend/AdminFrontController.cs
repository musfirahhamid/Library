using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers.AdminModule.Frontend
    {
    public class AdminFrontController : Controller
        {
        // GET: AdminFrontController
        public ActionResult Index()
            {
            return View();
            }

        public ActionResult AddPublication()
            {
            return View();
            }
        public ActionResult AllBookData()
            {
            return View();
            }
        public ActionResult AllDepartmentData()
            {
            return View();
            }
        public ActionResult AllStudentData()
            {
            return View();
            } 
        public ActionResult IssueBook()
            {
            return View();
            }
        public ActionResult Permission()
            {
            return View();
            }
        public ActionResult UserRole()
            {
            return View();
            }
        public ActionResult AssignRole()
            {
            return View();
            }
        }
    }
