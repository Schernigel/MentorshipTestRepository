using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mentorship.ServerControl.CustomButton
{
    [ToolboxData("<{0}:StoneButton runat=server></{0}:StoneButton>")]
    public class StoneButton : WebControl, IPostBackEventHandler
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

        public event EventHandler Click;

        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ID);
            writer.AddAttribute("enabled", Enabled);
            writer.AddAttribute("size", Size);
            writer.AddAttribute("theme", Theme);
            //writer.AddAttribute("onclick", "ShowInfo(this)");

            writer.AddAttribute(HtmlTextWriterAttribute.Onclick, Page.ClientScript.GetPostBackEventReference(this, string.Empty));

            writer.RenderBeginTag("StoneButton");
            writer.RenderBeginTag("text");
            writer.Write(Text);
            writer.RenderEndTag();
            writer.RenderEndTag();
        }

        public void RaisePostBackEvent(string eventArgument)
        {
            ButtonClickEvent();
        }

        protected virtual void ButtonClickEvent()
        {
            Click?.Invoke(this, new EventArgs());
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Onclick,
                Page.ClientScript.GetPostBackEventReference(this, String.Empty));
            base.AddAttributesToRender(writer);
        }
    }
}

//    if (!cs.IsClientScriptBlockRegistered("MyScript"))
//            {
//                StringBuilder javaScriptCode = new StringBuilder();
//javaScriptCode.Append("<script type=\"text/javascript\"> function ShowInfo(obj) {");
//                javaScriptCode.Append("var info = 'Was pressed '+obj.innerText;");
//                javaScriptCode.Append("alert(info);");
//                javaScriptCode.Append("} </script>");

//                cs.RegisterClientScriptBlock(this.GetType(), "MyClientScript", javaScriptCode.ToString());
//}

//            base.OnInit(e);