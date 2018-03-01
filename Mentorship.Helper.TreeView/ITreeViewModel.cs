using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentorship.Helper.TreeView
{
    public interface ITreeViewModel
    {
         int ID { get; set; }

         string Name { get; set; }

         string Description { get; set; }

         int? ParentId { get; set; }

         string Disabled { get; set; }
    }
}
