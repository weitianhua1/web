using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Test1Controller : Controller
    {
        // GET: Test1
        public ActionResult GetView()
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

            //ViewData["greeting"] = greeting;
            ViewBag.greeting = greeting;
            Customer emp = new Customer();
            emp.CustomerNmae = "上帝";
            emp.Address = "非洲";
            //ViewData["Empkey"] = emp;
            ViewBag.Empkey = emp;
            return View("GetView", emp);
        }
    }
}