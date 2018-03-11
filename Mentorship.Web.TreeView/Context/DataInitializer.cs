using Mentorship.Web.TreeView.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Mentorship.Web.TreeView.Context
{
    public class DataInitializer : CreateDatabaseIfNotExists<TreeViewContext>
    {
        protected override void Seed(TreeViewContext context)
        {
            context.Categories.AddRange(new List<Category>() {
                                              new Category { Id = 1, ParentId = null, Disabled = null, Text = "Node 1", HasChildren = true },
                                              new Category { Id = 2, ParentId = 1, Disabled = null, Text = "Sub Node 1", HasChildren = true },
                                              new Category { Id = 3, ParentId = 2, Disabled = null, Text = "Sub Sub Node 1", HasChildren = true },
                                              new Category { Id = 4, ParentId = 3, Disabled = null, Text = "First Nested Item", HasChildren = false },
                                              new Category { Id = 5, ParentId = 3, Disabled = null, Text = "Second Nested Item", HasChildren = false },
                                              new Category { Id = 6, ParentId = 3, Disabled = null, Text = "Third Nested Item", HasChildren = false },
                                              new Category { Id = 7, ParentId = 3, Disabled = null, Text = "Fourth Nested Item", HasChildren = false },

                                              new Category { Id = 8, ParentId = 2, Disabled = null, Text = "Item 1", HasChildren = false },
                                              new Category { Id = 9, ParentId = 2, Disabled = null, Text = "Item 2", HasChildren = false },
                                              new Category { Id = 10, ParentId = 2, Disabled = null, Text = "Item 3", HasChildren = false },

                                              new Category { Id = 11, ParentId = 1, Disabled = null, Text = "Yet Another One", HasChildren = true },

                                              new Category { Id = 12, ParentId = 11, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 13, ParentId = 11, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 14, ParentId = 11, Disabled = null, Text = "Item", HasChildren = false },

                                              new Category { Id = 15, ParentId = 1, Disabled = "disabled", Text = "Disabled Nested Items", HasChildren = true },

                                              new Category { Id = 16, ParentId = 15, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 17, ParentId = 15, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 18, ParentId = 15, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 19, ParentId = 15, Disabled = null, Text = "Item", HasChildren = false },

                                              new Category { Id = 20, ParentId = 1, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 21, ParentId = 1, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 22, ParentId = 1, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 23, ParentId = 1, Disabled = null, Text = "Item", HasChildren = false },

                                              new Category { Id = 24, ParentId = null, Disabled = null, Text = "This One is Open by Default...", HasChildren = true },

                                              new Category { Id = 25, ParentId = 24, Disabled = null, Text = "And Contains More Nested Items...", HasChildren = true },

                                              new Category { Id = 26, ParentId = 25, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 27, ParentId = 25, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 28, ParentId = 25, Disabled = null, Text = "Item", HasChildren = false },

                                              new Category { Id = 29, ParentId = 24, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 30, ParentId = 24, Disabled = null, Text = "Item", HasChildren = false },
                                              new Category { Id = 31, ParentId = 24, Disabled = null, Text = "Item", HasChildren = false } });
        }
    }
}

  