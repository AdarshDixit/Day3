using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Day3_.Models;
namespace Day3_.ViewModels
{
    public class DeptEmpModel
    {
        Departments Dept = new Departments();
        Employee Emp = new Employee();
        public int EmployeeId { get { return Emp.EmployeeId; } set { Emp.EmployeeId = value; } }
        public int DepartmentId { get { return Dept.DepartmentId; } set { Dept.DepartmentId = value; } }
        public string EmployeeName { get { return Emp.EmployeeName; } set { Emp.EmployeeName = value; } }
        public string DepartmentName { get { return Dept.DepartmentName; } set { Dept.DepartmentName = value; } }


    }
}