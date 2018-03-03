using System.Text;
using System.Web.Mvc;

namespace Mentorship.Control.CusomButton
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString StoneButtonExtension(this HtmlHelper helper, string text = "", string size = "", string enabled = "", string theme = "", string onclick = "")
        {
            return CreateTag(text, size, enabled, theme, onclick);
        }

        public static MvcHtmlString StoneButtonStatic(string text = "", string size = "", string enabled = "", string theme = "", string onclick = "")
        {
            return CreateTag(text, size, enabled, theme, onclick);
        }

        private static MvcHtmlString CreateTag(string text = "", string size = "", string enabled = "", string theme = "", string onclick = "")
        {
            var textBuilder = new StringBuilder();

            textBuilder.AppendFormat("<text>{0}<text/>", text);

            var tag = new TagBuilder("stoneButton")
            {
                InnerHtml = textBuilder.ToString()
            };

            tag.Attributes.Add("size", size);
            tag.Attributes.Add("enabled", enabled);
            tag.Attributes.Add("theme", theme);
            tag.Attributes.Add("onclick", string.Concat(onclick,"(this)"));

            return new MvcHtmlString(tag.ToString());
        }
    }
}