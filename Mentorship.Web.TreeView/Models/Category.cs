using Mentorship.Helper.TreeView;

namespace Mentorship.Web.TreeView.Models
{
    public class Category : ITreeViewModel
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Disabled { get; set; }

        public string Text { get; set; }

        public bool HasChildren { get; set; }
    }
}