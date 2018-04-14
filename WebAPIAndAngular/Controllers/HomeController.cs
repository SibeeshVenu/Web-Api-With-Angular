using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAPIAndAngular.Models;

namespace WebAPIAndAngular.Controllers
{
    public class HomeController : Controller
    {
        private SibeeshPassionEntities db = new SibeeshPassionEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
