using MVCHyderabad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHyderabad.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult print()
        {
            EmpDep ed = new EmpDep { FirstName = "Capgemini", SecondName = "Hyd", DeptName = "Financial Services" };
            return View(ed);
        }


    }
}