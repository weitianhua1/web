using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models; 


namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "hello";
        }
        public Customer GetCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerName = "QAQ";
            ct.Address = "QAQ";
            return ct;
        }
        public ActionResult GetView()
        {
            //    // 获取当前时间
            //    if (DateTime.Now.Hour > 12)
            //    {
            //        return View("YourView");
            //    }
            //    else
            //    {
            //        return View("MyView");
            //    }
            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "早上好";
            }
            else
            {
                greeting = "下午好";
            }
            ViewData["greeting"] = greeting;
        Employee emp = new Employee();

            emp.Name = "三八";
    
            emp.Salary = 46859;
            ViewData["EmpKey"] = emp;


            return View("MyView");

        }
    }
}