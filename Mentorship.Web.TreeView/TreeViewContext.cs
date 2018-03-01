using Mentorship.Web.TreeView.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mentorship.Web.TreeView
{
    public class TreeViewContext : DbContext
    {
        public TreeViewContext() { }

        public DbSet<Category> Categories { get; set; }
    }
}