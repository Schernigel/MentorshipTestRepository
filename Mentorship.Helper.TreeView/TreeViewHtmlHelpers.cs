using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Mentorship.Helper.TreeView
{
    public static class TreeViewHtmlHelpers
    {
        public static MvcHtmlString TreeViewHelper(this HtmlHelper helper, IEnumerable<ITreeViewModel> model)
        {
            var s = GetRoots(model.ToList());
            return new MvcHtmlString(s);
        }

        public static string GetRoots(List<ITreeViewModel> modelList)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ITreeViewModel item in modelList)
            {
                if (item.ParentId == null)
                {
                    sb.AppendLine("<ul>");
                    sb.Append("<li>");

                    if(item.Type != null)
                    {
                        sb.AppendFormat($"<input type='{item.Type}' id='{item.IdText}' checked='checked'><label for='{item.IdText}'>{item.Text}</label>");
                    }
                    else
                    {
                        sb.AppendFormat($"<a href='./ '>{item.Text}</a>");
                    }
                    
                    sb = GetChilds(modelList, item, sb.ToString());

                    sb.AppendLine("</li>\n");
                    sb.AppendLine("</ul>\n");
                }
            }

            return sb.ToString();
        }

        public static StringBuilder GetChilds(List<ITreeViewModel> modelList, ITreeViewModel previus, string tag)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tag);

            //int? previusParentId = previus.ParentId;
            int? currentParentId = -1;

            bool change = false;

            foreach (ITreeViewModel item in modelList)
            {
                if (item.ParentId == previus.ID)
                {
                    sb.AppendLine("<ul>\n");
                    sb.Append("<li>");

                    if (item.Type != null)
                    {
                        sb.AppendFormat($"<input type='{item.Type}' id='{item.IdText}' checked='checked' disabled='{item.Disabled}'><label for='{item.IdText}'>{item.Text}</label>");
                    }
                    else
                    {
                        sb.AppendFormat($"<a href='./ '>{item.Text}</a>");
                    }

                    sb = GetChilds(modelList, item, sb.ToString());

                    sb.AppendLine("</li>\n");
                    sb.AppendLine("</ul>\n");
                }
            }

            return sb;
        }
    }
}




