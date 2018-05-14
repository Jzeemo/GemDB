using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gendb.Controllers
{
    public class SqlgenController : Controller
    {
        // GET: Sqlgen
        public ActionResult Index()
        {
            return View("~/Views/Sqlgen/SqlIndex.cshtml");
        }
    }
}