namespace Mentorship.Helper.TreeView.Interfaces
{
    public interface INode
    {
        int Id { get; set; }
        string Text { get; set; }
        int? ParentId { get; set; }
        bool HasChildren { get; set; }
    }
}
