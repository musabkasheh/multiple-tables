using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tabel.Models;


namespace tabel.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult Index()
        {
            tbl_employeeEntities tbl = new tbl_employeeEntities();
            List<employee> tab = tbl.employees.ToList();
            return View(tab);
        }
        public ActionResult details(int id)
        {
            tbl_employeeEntities empl = new tbl_employeeEntities();
            employee employee = empl.employees.Single(emp => emp.id == id);

            return View(employee);
        }
    }
}