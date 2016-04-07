using NW.Data;
using NW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NW.WebApp.Controllers
{
    public class CategoryController : NorthwindController
    {
        public CategoryController()
            : this(null) { }

        public CategoryController(IRepository r)
            : base(r) { }

        public ActionResult Index()
        {
            IEnumerable<Category> cats;
            try
            {
                cats = r.GetAllCategories();
            }
            catch
            {
                return View("Error");
            }

            return View(cats);
        }

        public ActionResult Edit(int id)
        {
            Category cat = r.GetAllCategories().Single(c => c.CategoryID == id);
            return View(cat);
        }
    }
}