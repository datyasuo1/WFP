using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T2010A_WAD.Controllers
{
    public class BrandControllerController : Controller
    {
        // GET: BrandController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateNew()
        {
            return View();
        }
        public ActionResult UpdateBrand()
        {
            return View();
        }
        public ActionResult DeleteBrand()
        {
            return View();
        }
    }
}