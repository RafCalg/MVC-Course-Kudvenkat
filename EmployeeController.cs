using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();//Establish a connection to the database - Uses EmployeeContext.cs and Web.config connectionString="server=localhost\sqlexpress; database=Sample; integrated security=SSPI"

            List<Employee> employees = employeeContext.Employees.Where(employee => employee.DepartmentId == departmentId).ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();

            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }
    }
    
}