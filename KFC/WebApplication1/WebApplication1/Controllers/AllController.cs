using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AllController : Controller
    {
        // GET: All
        public ActionResult AllView()
        {
            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.Name = "三八";
            vmEmp.Salary = 9877;
            vmEmp.CustomerName = "三八";
            vmEmp.Address = "非洲";
            return View(vmEmp);

        }
    }
}