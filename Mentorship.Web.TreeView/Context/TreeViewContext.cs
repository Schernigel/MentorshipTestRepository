using Mentorship.Web.TreeView.Context;
using Mentorship.Web.TreeView.Models;
using System.Data.Entity;

namespace Mentorship.Web.TreeView
{
    public class TreeViewContext : DbContext
    {
        public TreeViewContext() : base("TreeViewConnection") { } //Where is connectionString?

        public DbSet<Category> Categories { get; set; }

        static TreeViewContext()
        {
            Database.SetInitializer(new DataInitializer());
        }
    }
}