using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBC.PL
{
    public partial class ElectricityMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public bool Logout
        {
            get { return divLogout.Visible; }
            set { divLogout.Visible = value; }
        }

        public bool Menu
        {
            get { return divMenu.Visible; }
            set { divMenu.Visible = value; }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}