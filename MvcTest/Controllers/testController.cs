using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            ViewData["Info"] = "Hello";
            return View();
        }
    }
}