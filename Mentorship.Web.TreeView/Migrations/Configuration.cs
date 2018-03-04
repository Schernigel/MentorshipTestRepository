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
                                              new Category { Id = 1, Type = "checkbox", IdText = "item-0", ParentId = null, Disabled = null, Text = "Node 1" },
                                              new Category { Id = 2, Type = "checkbox", IdText = "item-0-0", ParentId = 1, Disabled = null, Text = "Sub Node 1" },
                                              new Category { Id = 3, Type = "checkbox", IdText = "item-0-0-0", ParentId = 2, Disabled = null, Text = "Sub Sub Node 1" },
                                              new Category { Id = 4, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "First Nested Item" },
                                              new Category { Id = 5, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "Second Nested Item" },
                                              new Category { Id = 6, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "Third Nested Item" },
                                              new Category { Id = 7, Type = null, IdText = null, ParentId = 3, Disabled = null, Text = "Fourth Nested Item" },

                                              new Category { Id = 8, Type = null, IdText = null, ParentId = 2, Disabled = null, Text = "Item 1" },
                                              new Category { Id = 9, Type = null, IdText = null, ParentId = 2, Disabled = null, Text = "Item 2" },
                                              new Category { Id = 10, Type = null, IdText = null, ParentId = 2, Disabled = null, Text = "Item 3" },

                                              new Category { Id = 11, Type = "checkbox", IdText = "item-0-1", ParentId = 1, Disabled = null, Text = "Yet Another One" },

                                              new Category { Id = 12, Type = null, IdText = null, ParentId = 11, Disabled = null, Text = "Item" },
                                              new Category { Id = 13, Type = null, IdText = null, ParentId = 11, Disabled = null, Text = "Item" },
                                              new Category { Id = 14, Type = null, IdText = null, ParentId = 11, Disabled = null, Text = "Item" },

                                              new Category { Id = 15, Type = "checkbox", IdText = "item-0-2", ParentId = 1, Disabled = "disabled", Text = "Disabled Nested Items" },

                                              new Category { Id = 16, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },
                                              new Category { Id = 17, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },
                                              new Category { Id = 18, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },
                                              new Category { Id = 19, Type = null, IdText = null, ParentId = 15, Disabled = null, Text = "Item" },

                                              new Category { Id = 20, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },
                                              new Category { Id = 21, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },
                                              new Category { Id = 22, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },
                                              new Category { Id = 23, Type = null, IdText = null, ParentId = 1, Disabled = null, Text = "Item" },

                                              new Category { Id = 24, Type = "checkbox", IdText = "item-1", ParentId = null, Disabled = null, Text = "This One is Open by Default..." },

                                              new Category { Id = 25, Type = "checkbox", IdText = "item-1", ParentId = 24, Disabled = null, Text = "And Contains More Nested Items..." },

                                              new Category { Id = 26, Type = null, IdText = null, ParentId = 25, Disabled = null, Text = "Item" },
                                              new Category { Id = 27, Type = null, IdText = null, ParentId = 25, Disabled = null, Text = "Item" },
                                              new Category { Id = 28, Type = null, IdText = null, ParentId = 25, Disabled = null, Text = "Item" },

                                              new Category { Id = 29, Type = null, IdText = null, ParentId = 24, Disabled = null, Text = "Item" },
                                              new Category { Id = 30, Type = null, IdText = null, ParentId = 24, Disabled = null, Text = "Item" },
                                              new Category { Id = 31, Type = null, IdText = null, ParentId = 24, Disabled = null, Text = "Item" });

        }
    }
}