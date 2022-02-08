using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_on_Emp_Single_view_EF.Models;

namespace CRUD_on_Emp_Single_view_EF.Controllers
{
    public class EmployeeController : Controller
    {
        public void Forewardemp()
        {
            EmpModel obj = new EmpModel();
            ViewBag.emp = obj.GetEmp();
        }
        // GET: Employee
        public ActionResult Index()
        {
            Forewardemp();
            return View();
        }
        public ActionResult InsertEmp()
        {
            EmpModel obj = new EmpModel
            {
                Eno = int.Parse(Request["txtneweno"]),
                Ename = Request["txtnewename"],
                Esal = int.Parse(Request["txtnewesal"])
            };
            ViewData["insvalue"] = obj.InsertEmp();
            Forewardemp();
            return View("Index");
        }
        public ActionResult DeleteEmp()
        {
            EmpModel obj = new EmpModel
            {
                Eno = int.Parse(Request.QueryString["eno"])
            };
            ViewData["delvalue"] = obj.DeleteEmp();
            Forewardemp();
            return View("Index");
        }
        public ActionResult EditEmp()
        {
            EmpModel obj = new EmpModel
            {
                Eno = int.Parse(Request.QueryString["eno"])
            };
            Forewardemp();
            return View("Index");
        }
        public ActionResult Cancel()
        {
            Forewardemp();
            return View("Index");
        }
        public ActionResult UpdatedEmp()
        {
            EmpModel obj = new EmpModel
            {
                Eno = int.Parse(Request["txteno"]),
               Esal = int.Parse(Request["txtnewsal"])
            };
            ViewData["updvalue"] = obj.UpdateEmp();
            Forewardemp();
            return View("Index");
        }
    }
}