using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApplication.Controllers
{
    public partial class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}