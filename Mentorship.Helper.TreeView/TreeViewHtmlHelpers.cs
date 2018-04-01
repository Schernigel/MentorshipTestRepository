using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mentorship.Helper.TreeView
{
    public static class TreeViewHtmlHelpers
    {
        public static MvcHtmlString TreeViewHelper<TModel>(this HtmlHelper<TModel> helper,
            IEnumerable<ITreeViewModel> model) where TModel : IEnumerable<ITreeViewModel>
        {
            var divTreeView = new TagBuilder("div");
            divTreeView.AddCssClass("css-treeview");
            var ulRoot = new TagBuilder("ul");
            BuildTreeView(ulRoot, model);
            divTreeView.InnerHtml += ulRoot;
            return new MvcHtmlString(divTreeView.ToString(TagRenderMode.Normal));
        }

        private static void BuildTreeView<TModel>(TagBuilder rootTag, TModel model, int? parentId = null) where TModel : IEnumerable<ITreeViewModel>
        {
            foreach (var node in model.Where(m => m.ParentId == parentId))
            {
                var liSubItem = new TagBuilder("li");
                var nodeId = $"item-{node.Id}";
                if (node.HasChildren)
                {
                    var cbItem = new TagBuilder("input");
                    cbItem.MergeAttribute("id", nodeId);
                    cbItem.MergeAttribute("type", "checkbox");
                    if(node.Disabled == "disabled")
                    {
                        cbItem.MergeAttribute("disabled", node.Disabled);
                    }
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
                    spanItem.MergeAttribute("id", nodeId);
                    spanItem.SetInnerText(node.Text);
                    liSubItem.InnerHtml += spanItem;
                }

                rootTag.InnerHtml += liSubItem;
            }
        }
    }
}




