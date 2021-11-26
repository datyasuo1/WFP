using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2010A_WAD.Models;

namespace T2010A_WAD.Controllers
{
    public class CategoriesController : Controller
    {
        private DataContext context = new DataContext();
        // GET: Categories
        public ActionResult Index()
        {
            ViewData["Page-Title"] = "Categories Page";
            ViewBag.PageTitle = "Demo Title";
            //var category = new Category() { Id = 1, CategoryName = "Fashion" };
            //ViewBag.Category = category;
            //var list = new List<Category>();
            //list.Add(new Category() { Id = 1, CategoryName = "Fashion" });
            //list.Add(new Category() { Id = 2, CategoryName = "Watch" });
            //list.Add(new Category() { Id = 3, CategoryName = "Phone" });
            var list = context.Categories.ToList();


            return View(list);// truyeenf thawngr model sang
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult UpdateCategory()
        {
            return View();
        }
        public ActionResult DeleteCategory()
        {
            return View();
        }
    }
}