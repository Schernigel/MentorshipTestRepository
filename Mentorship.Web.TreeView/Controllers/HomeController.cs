using System.Web.Mvc;
using System.Linq;
using Mentorship.Web.TreeView.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Mentorship.Web.TreeView.Context;

namespace Mentorship.Web.TreeView.Controllers
{
    public class HomeController : Controller
    {
        TreeViewContext context = new TreeViewContext();
        
        public ActionResult Index()
        {
            return View(context.Categories.ToList());
        }

        //public ViewResult Refresh()
        //{
        //    var data = new DataInitializer();
        //    data.InitializeDatabase(context);
        //    return View("Index", context.Categories.ToList());
        //}

        public JsonResult SaveCategory(int? parentId, string text)
        {
            object result;
            try
            {
                var category = new Category();

                category.Text = text;
                category.ParentId = parentId;
                category.HasChildren = false;

                context.Categories.Add(category);
                context.SaveChanges();

                 result = new { Message = "", Status = true };

            }
            catch (Exception ex)
            {
                 result = new { Message = "", Status = false };
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteCategory(int currentId)
        {
            object result;
            try
            {
                using (TreeViewContext context = new TreeViewContext())
                {
                    List<Category> deleteList = DeleteHelper(currentId, 0);

                    deleteList.AddRange(context.Categories.Where(n => n.Id == currentId).ToList());
                   
                    foreach(Category cat in deleteList)
                    {
                        context.Categories.Attach(cat);
                    }

                    context.Categories.RemoveRange(deleteList);
                    context.SaveChanges();

                    result = new { Message = "", Status = true };

                }
            }
            catch (Exception ex)
            {
                result = new { Message = "", Status = false };
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private static List<Category> DeleteHelper(int id, int position)
        {

            var deletelist = new List<Category>();

            using (TreeViewContext context = new TreeViewContext())
            {
                deletelist.AddRange(context.Categories.Where(n => n.ParentId == id).ToList());

                for (int i = position; i < deletelist.Count; i++)
                {
                    deletelist.AddRange((DeleteHelper(deletelist[i].Id,++position)));
                }
            }
            return deletelist;
        }
    }
}
