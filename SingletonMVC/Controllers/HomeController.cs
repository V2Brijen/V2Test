using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SingletonMVC.Models;

namespace SingletonMVC.Controllers
{
    public class HomeController : Controller
    {
        public masterEntities context = new masterEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            Sample emp = new Sample();
            //emp.ID = 1;
            emp.Name = "brijen1";
            emp.SomeText = null;
            context.Samples.AddObject(emp);
            //Singleton.Instance.context.Employees.AddObject(emp);
            //Employee emp1 = new Employee();
            //emp1.EID = 2;
            //emp1.EName = "brijen2";
            //emp1.ReportsTO = null;
            //context.Employees.AddObject(emp);
            ////Singleton.Instance.context.Employees.AddObject(emp);
            //emp = new Employee();
            //emp.EID = 3;
            //emp.EName = "brijen3";
            //emp.ReportsTO = null;
            //context.Employees.AddObject(emp);
            ////Singleton.Instance.context.Employees.AddObject(emp);
            //emp = new Employee();
            //emp.EID = 4;
            //emp.EName = "brijen4";
            //emp.ReportsTO = null;
            //context.Employees.AddObject(emp);

            //context.ObjectStateManager.ChangeObjectState(context, System.Data.EntityState.Modified);

            context.SaveChanges();
            //SaveChanges();

            return View();
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
