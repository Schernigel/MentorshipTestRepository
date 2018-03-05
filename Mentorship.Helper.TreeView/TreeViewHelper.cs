using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Mentorship.Helper.TreeView.Interfaces;

namespace Mentorship.Helper.TreeView
{
    public static class TreeViewHelperClass 
    {
        public static MvcHtmlString CustomTreeViewHelper<TModel>(this HtmlHelper<TModel> helper,
            IEnumerable<INode> model) where TModel : IEnumerable<INode>
        {
            var divTreeView = new TagBuilder("div");
            divTreeView.AddCssClass("css-treeview");
            var ulRoot = new TagBuilder("ul");
            BuildTreeView(ulRoot, model);
            divTreeView.InnerHtml += ulRoot;
            return new MvcHtmlString(divTreeView.ToString(TagRenderMode.Normal));
        }

        private static void BuildTreeView<TModel>(TagBuilder rootTag, TModel model, int? parentId = null) where TModel : IEnumerable<INode>
        {
            foreach (var node in model.Where(m => m.ParentId == parentId))
            {
                var liSubItem = new TagBuilder("li");
                var parId = parentId != null ? parentId.Value + "-" : string.Empty;
                var nodeId = $"item-{parId}{node.Id}";
                if (node.HasChildren)
                {
                    var cbItem = new TagBuilder("input");
                    cbItem.MergeAttribute("id", nodeId);
                    cbItem.MergeAttribute("type", "checkbox");
                    var lblItem = new TagBuilder("label");
                    lblItem.MergeAttribute("for", nodeId);
                    lblItem.SetInnerText(node.Text);
                    liSubItem.InnerHtml += cbItem;
                    liSubItem.InnerHtml += lblItem;
                    var ulGroup = new TagBuilder("ul");
                    BuildTreeView(ulGroup, model, node.Id);
                    liSubItem.InnerHtml += ulGroup;
                }
                else
                {
                    var spanItem = new TagBuilder("span");
                    spanItem.SetInnerText(node.Text);
                    spanItem.MergeAttribute("id", nodeId);
                    liSubItem.InnerHtml += spanItem;
                }

                rootTag.InnerHtml += liSubItem;
            }
        }
    }
}
