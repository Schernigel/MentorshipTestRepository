using Mentorship.Helper.TreeView.Interfaces;

namespace Mentorship.Web.TreeView.Models
{ 
    public class Node : INode
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? ParentId { get; set; }
        public bool HasChildren { get; set; }
    }
}