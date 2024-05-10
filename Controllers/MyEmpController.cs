using CRUD_MVC_Demo_100524.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CRUD_MVC_Demo_100524.Controllers
{
    public class MyEmpController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(tblLoginModel lm)
        {
            DB_EMP_100524Entities _dbContext = new DB_EMP_100524Entities();

            if (ModelState.IsValid)
            {
                var lg = _dbContext.tblLogins.FirstOrDefault(x => x.userId == lm.userId && x.password == lm.password);
                if (lg!= null)
                {
                    FormsAuthentication.SetAuthCookie(lm.userId, false);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("HomePage");
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        // GET: MyEmp
        [Authorize]
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