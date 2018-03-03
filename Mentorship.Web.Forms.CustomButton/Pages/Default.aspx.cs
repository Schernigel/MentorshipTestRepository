using Mentorship.ServerControl.CustomButton;
using System;

namespace Mentorship.Web.Forms.CustomButton.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
            first.Click += StoneButton1_Click;
        }

        private void StoneButton1_Click(object sender, EventArgs e)
        {
            label1.Text = sender.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            StoneButton2.Click += new EventHandler(StoneButton_Click);
        }

        protected void StoneButton_Click(object sender, EventArgs e)
        {
            var message = String.Format("You clicked the button at {0}.", DateTime.Now.ToLongTimeString());
            Label1.Text = message;
        }
    }
}