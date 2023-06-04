using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tabel.Models;
namespace tabel.Controllers
{
    public class departmentController : Controller
    {
        // GET: department
        public ActionResult Index()
        {

            tbl_employeeEntities1 employeecon = new tbl_employeeEntities1();
            List<department> departments = employeecon.departments.ToList();
            return View(departments);
            
        }
    }
}