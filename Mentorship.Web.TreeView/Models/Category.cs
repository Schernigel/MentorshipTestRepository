using Mentorship.Helper.TreeView;

namespace Mentorship.Web.TreeView.Models
{
    public class Category : ITreeViewModel
    {
        public int ID { get; set; }

        public string Type { get; set; }

        public string IdText { get; set; }

        public int? ParentId { get; set; }

        public string Disabled { get; set; }

        public string Text { get; set; }
    }
}