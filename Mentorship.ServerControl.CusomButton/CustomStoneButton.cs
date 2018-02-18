using System;
using System.Collections.Specialized;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mentorship.ServerControl.CustomButton
{
    [ToolboxData("<{0}:StoneButton runat=server></{0}:StoneButton>")]
    public class StoneButton: WebControl, IPostBackDataHandler
    {
        private string _enabled = "true";
        public string Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        private string _size = null;
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private string _theme = null;
        public string Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }
        private string _text = null;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute("enabled", Enabled);
            writer.AddAttribute("size", Size);
            writer.AddAttribute("theme", Theme);

            writer.RenderBeginTag("StoneButton");
            writer.RenderBeginTag("text");
            writer.Write(Text);
            writer.RenderEndTag();
            writer.RenderEndTag();
        }

        public bool LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            throw new NotImplementedException();
        }

        public void RaisePostDataChangedEvent()
        {
            throw new NotImplementedException();
        }

    }
}
