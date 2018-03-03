using Mentorship.ServerControl.CustomButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mentorship.Web.Forms.CustomButton.Pages
{
    public partial class Default : System.Web.UI.Page
    {
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