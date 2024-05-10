using CRUD_MVC_Demo_100524.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC_Demo_100524.Controllers
{
    public class MyEmpController : Controller
    {
        // GET: MyEmp
        public ActionResult Index()
        {
            DB_EMP_100524Entities dbo=new DB_EMP_100524Entities();
            List<tblEmployee> emps = dbo.tblEmployees.ToList();
            dbo.Dispose();
            return View(emps);
        }

        
        public ActionResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        //create operation
        public ActionResult AddEmp(tblEmployeeModel em) 
        {
            DB_EMP_100524Entities dbo = new DB_EMP_100524Entities();

            tblEmployee emp = new tblEmployee();
            emp.dept=em.dept;
            emp.empName=em.empName;
            emp.Salary = em.Salary;

            dbo.tblEmployees.Add(emp);
            //int n=dbo.SaveChanges();
            //if (n>0)
            //{
            return RedirectToAction("Index");
            //}
            return View();
        }
    }
}