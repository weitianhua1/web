using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListViewModel empListModel = new EmployeeListViewModel();



            //将处理过的数据列表送给强视图类型对象
            empListModel.EmployeeViewList = getEmpVmList();
            empListModel.Greeting = getGreeting();
            empListModel.UserName = getUserName();

            return View(empListModel);
        }

        public ActionResult AddNew()
        {
            return View("createEmplotee");
        }

        [NonAction]
        List<EmployeeViewModel> getEmpVmList()
        {
            //实例化员工信息业务层
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            //员工原始数据列表，获取来自业务层类的数据
            var listEmp = empBL.GetEmployeeList();
            //员工原始数据加工后的视图数据列表，当前状态是空的
            var listEmpVm = new List<EmployeeViewModel>();

            foreach (var item in listEmp)
            {
                EmployeeViewModel empVmObj = new EmployeeViewModel();
                empVmObj.EmployeeName = item.Name;
                empVmObj.EmployeeSalary = item.Salary.ToString("C");
                if (item.Salary > 2000)
                {
                    empVmObj.EmployeeGrade = "骚猪";
                }
                else
                {
                    empVmObj.EmployeeGrade = "乞丐";
                }
                listEmpVm.Add(empVmObj);
            }
            return listEmpVm;
        }

        [NonAction]
        string getGreeting()
        {
            string greeting;
            //获取当前时间
            DateTime dt = DateTime.Now;
            //获取当前小时
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "早上好";
            }
            else
            {
                greeting = "中午好";
            }
            return greeting;
        }
        [NonAction]
        string getUserName()
        {
            return "管理员";
        }
    }
}
