using EBC.BLL;
using EBC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBC.PL
{
    public partial class SearchDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            Master.Logout = true;
            Master.Menu = true;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtuserId.Text);

            Electricity Elect = new Electricity();
            Elect = UserBLL.ElectricitySearch(id);

            txtUserName.Text = Elect.customerName;
            txtlast.Text = Elect.lastReading.ToString();
            txtcurrent.Text = Elect.currentReading.ToString();
            txtunits.Text = Elect.units.ToString();
            txtprice.Text = Elect.price.ToString();
        }
    }
}