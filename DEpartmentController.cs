using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: DEpartment
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext(); // Connection to the databse
            List<Department> departments = employeeContext.Department.ToList();

            return View(departments);

        }
    }
}