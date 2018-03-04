using Mentorship.Web.TreeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mentorship.Web.TreeView.Controllers
{
    public class HomeController : Controller
    {
        private TreeViewContext context = new TreeViewContext();
        // GET: Home
        public ActionResult Index()
        {
            var aaa = context.Categories.ToList();
            return View(context.Categories);
        }
    }
}