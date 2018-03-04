namespace Mentorship.Web.TreeView.Migrations
{
    using Mentorship.Web.TreeView.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Mentorship.Web.TreeView.TreeViewContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mentorship.Web.TreeView.TreeViewContext context)
        {
            context.Categories.AddOrUpdate(c => c.IdText,
                                              new Category { ID = 1, Type = "checkbox", IdText = "item-0", ParentId = null, Disabled = null, Text = "Node 1" },
                                              new Category { ID = 2, Type = "checkbox", IdText = "item-0-0", ParentId = 1, Disabled = null, Text = "Sub Node 1" },
                                              new Category { ID = 3, Type = "checkbox", IdText = "item-0-0-0", ParentId = 2, Disabled = null, Text = "Sub Sub Node 1" },
                                              new Category { ID = 4, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "First Nested Item" },
                                              new Category { ID = 5, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "Second Nested Item" },
                                              new Category { ID = 6, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "Third Nested Item" },
                                              new Category { ID = 7, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "Fourth Nested Item" },

                                              new Category { ID = 8, Type = null, IdText = null, ParentId = 2, Disabled = null, Text = "Item 1" },
                                              new Category { ID = 9, Type = null, IdText = null, ParentId = 2, Disabled = null, Text = "Item 2" },
                                              new Category { ID = 10, Type = null, IdText = null, ParentId = 2, Disabled = null, Text = "Item 3" },

                                              new Category { ID = 11, Type = "checkbox", IdText = "item-0-1", ParentId = 1, Disabled = null, Text = "Yet Another One" },

                                              new Category { ID = 12, Type = null, IdText = null, ParentId = 11, Disabled = null, Text = "Item" },
                                              new Category { ID = 13, Type = null, IdText = null, ParentId = 11, Disabled = null, Text = "Item" },
                                              new Category { ID = 14, Type = null, IdText = null, ParentId = 11, Disabled = null, Text = "Item" },

                                              new Category { ID = 15, Type = "checkbox", IdText = "item-0-2", ParentId = 1, Disabled = "disabled", Text = "Disabled Nested Items" },

                                              new Category { ID = 16, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },
                                              new Category { ID = 17, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },
                                              new Category { ID = 18, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },
                                              new Category { ID = 19, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },

                                              new Category { ID = 20, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },
                                              new Category { ID = 21, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },
                                              new Category { ID = 22, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },
                                              new Category { ID = 23, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },

                                              new Category { ID = 24, Type = "checkbox", IdText = "item-1", ParentId = null, Disabled = null, Text = "This One is Open by Default..." },

                                              new Category { ID = 25, Type = "checkbox", IdText = "item-1", ParentId = 24, Disabled = null, Text = "And Contains More Nested Items..." },

                                              new Category { ID = 26, Type = null, IdText = null, ParentId = 25, Disabled = null, Text = "Item" },
                                              new Category { ID = 27, Type = null, IdText = null, ParentId = 25, Disabled = null, Text = "Item" },
                                              new Category { ID = 28, Type = null, IdText = null, ParentId = 25, Disabled = null, Text = "Item" },

                                              new Category { ID = 29, Type = null, IdText = null, ParentId = 24, Disabled = null, Text = "Item" },
                                              new Category { ID = 30, Type = null, IdText = null, ParentId = 24, Disabled = null, Text = "Item" },
                                              new Category { ID = 31, Type = null, IdText = null, ParentId = 24, Disabled = null, Text = "Item" });

        }
    }
}