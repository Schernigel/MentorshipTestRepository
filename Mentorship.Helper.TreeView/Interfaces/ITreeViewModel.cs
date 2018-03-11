namespace Mentorship.Helper.TreeView
{
    public interface ITreeViewModel
    {
         int Id { get; set; }

         int? ParentId { get; set; }

         string Disabled { get; set; }

         string Text { get; set; }

         bool HasChildren { get; set; }
    }
}
