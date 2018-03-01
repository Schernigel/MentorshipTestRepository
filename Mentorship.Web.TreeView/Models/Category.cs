using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Mentorship.Helper.TreeView;

namespace Mentorship.Web.TreeView.Models
{
    public class Category : ITreeViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public string Disabled { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Childs { get; set; }
    }
}