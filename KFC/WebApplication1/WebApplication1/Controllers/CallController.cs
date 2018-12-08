using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication2.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            {
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
                ViewBag.greeting = greeting;
                Customer cus = new Customer();
                Employee emp = new Employee();
                ViewData["EmpKey"] = emp;
                emp.Name = "三八";
                emp.Salary = 1000;
                cus.CustomerNmae = "三八";
                cus.Address = "非洲";
                return View(cus);
            }
        }
    }
}