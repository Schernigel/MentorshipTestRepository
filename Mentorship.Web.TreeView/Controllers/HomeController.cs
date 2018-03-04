using Mentorship.Web.TreeView.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Mentorship.Helper.TreeView.Interfaces;

namespace Mentorship.Web.TreeView.Controllers
{
    public class HomeController : Controller
    {
        //private TreeViewContext context = new TreeViewContext();
        // GET: Home
        public ActionResult Index()
        {
            //var aaa = context.Categories.ToList();
            var treeView = new List<INode>
            {
                new Node() {Id = 1, Text = "Node 1", ParentId = null, HasChildren = true},
                new Node() {Id = 2, Text = "Node 2", ParentId = null, HasChildren = true},
                new Node() {Id = 3, Text = "Node 1.1", ParentId = 1, HasChildren = true},
                new Node() {Id = 4, Text = "Node 1.1.1", ParentId = 3, HasChildren = false},
                new Node() {Id = 5, Text = "Node 1.1.2", ParentId = 3, HasChildren = false},
                new Node() {Id = 6, Text = "Node 2.1", ParentId = 2, HasChildren = false},
                new Node() {Id = 7, Text = "Node 2.2", ParentId = 2, HasChildren = false},
                new Node() {Id = 8, Text = "Node 3", ParentId = null, HasChildren = false},
                new Node() {Id = 9, Text = "Node 1.2", ParentId = 1, HasChildren = false}
            };
            return View(treeView);
        }
    }
}