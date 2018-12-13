using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            var list = new List<Employee>();
            Employee emp = new Models.Employee();
            emp.Name = "三八";
            emp.Salary = 2999;
            list.Add(emp);

            emp = new Models.Employee();
            emp.Name = "三九";
            emp.Salary = 3000;
            list.Add(emp);

            emp = new Models.Employee();
            emp.Name = "四十一";
            emp.Salary = 1999;
            list.Add(emp);

            return list;
        }
    }
}