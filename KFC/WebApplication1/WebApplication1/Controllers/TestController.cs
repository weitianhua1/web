using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "hello wrold";
        }
        public Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerNmae = "abc";
            ct.Address = "def";
            return ct;
        }

      
  public ActionResult GetView()
        {
            //获取当前时间
            //获取当前小时数
            //根据小时数判断需要返回那个视图,<12 返回myview 否则返回yourview>
            //int h = 0;
            //h = DateTime.Now.Hour;
            //if (h < 12)
            //{
            //    return View("MyView");
            //}
            //else
            //{
            //    return View("YourView");
            //}

            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "早上好";
            }
            else
            {
                greeting = "中午好";
            }
            ViewData["greeting"] = greeting;
            //ViewBag.greeting= greeting;
            Employee emp = new Employee();
            emp.Name = "三八";
            emp.Salary = 10086;
            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.Name;
            vmEmp.EmployeeSalary = emp.Salary.ToString("C");
            if (emp.Salary > 1000)
            {
                vmEmp.EmployeeGrade = "小乞丐";
            }
            else
            {
                vmEmp.EmployeeGrade = "大骚猪";
            }

            //ViewData["EmpKey"] = emp;
            //ViewBag.EmpKey = emp;
            //vmEmp.UserName = "超级管理员";
            return View(vmEmp);

        }
    }
}