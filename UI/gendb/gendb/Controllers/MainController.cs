using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gendb.Helper;

namespace gendb.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            //sqlDBCreator.Connection();
            return View();
        }
    }
}