using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3_.ViewModels;
namespace Day3_.Controllers
{
    public class DeptEmpController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            DeptEmpModel DeptEmpModelObj = new DeptEmpModel();
            DeptEmpModelObj.DepartmentId = 101;
            DeptEmpModelObj.DepartmentName = "FS";
            DeptEmpModelObj.EmployeeId = 10001;
            DeptEmpModelObj.EmployeeName = "Adarsh";
            return View(DeptEmpModelObj);
        }

       
    }
}