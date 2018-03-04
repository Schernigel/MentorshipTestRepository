﻿namespace Mentorship.Helper.TreeView
{
    public interface ITreeViewModel
    {
         int ID { get; set; }

         string Type { get; set; }

         string IdText { get; set; }

         int? ParentId { get; set; }

         string Disabled { get; set; }

         string Text { get; set; }
    }
}
