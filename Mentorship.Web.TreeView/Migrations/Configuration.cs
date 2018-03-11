namespace Mentorship.Web.TreeView.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Mentorship.Web.TreeView.TreeViewContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TreeViewContext context)
        {
            base.Seed(context);
        }
    }
}