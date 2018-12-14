using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.DataAccessLayer;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {

            SalesERPDAL salesDal = new SalesERPDAL();
         
            //var list = salesDal.Employees.ToList();
            return salesDal.Employees.ToList();

            //Employee emp = new Models.Employee();
            //emp.Name = "三八";
            //emp.Salary = 2999;
            //list.Add(emp);

            //emp = new Models.Employee();
            //emp.Name = "三九";
            //emp.Salary = 3000;
            //list.Add(emp);

            //emp = new Models.Employee();
            //emp.Name = "四十一";
            //emp.Salary = 1999;
            //list.Add(emp);

            //return list;
        }
    }
}