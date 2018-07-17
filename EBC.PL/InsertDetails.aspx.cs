using EBC.BLL;
using EBC.Entity;
using EBC.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBC.PL
{
    public partial class InsertDetails : System.Web.UI.Page
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Electricity elect = new Electricity();
                elect.customerId = Convert.ToInt32(txtuserid.Text);
                elect.customerName = txtUserName.Text;
                elect.lastReading = Convert.ToInt32(txtlast.Text);
                elect.currentReading = Convert.ToInt32(txtcurrent.Text);
                
                txtunits.Text= (Convert.ToInt32(txtcurrent.Text)- Convert.ToInt32(txtlast.Text)).ToString();
                int unit = int.Parse(txtunits.Text);
                float cost = 0;

                if (0 < unit && unit <= 100)
                    cost = 1;
                else if (100 < unit && unit <= 250)
                    cost = 3;
                else if (250 < unit && unit <= 600)
                    cost = 5;
                else
                    cost = 10;

                txtprice.Text = (unit * cost).ToString();

                elect.units = Convert.ToInt32(txtunits.Text);
                elect.price = Convert.ToInt32(txtprice.Text);

                int recordsAffected = UserBLL.ElectricityInsert(elect);

                if (recordsAffected > 0)
                {
                    Response.Write("<script type='text/javascript'>alert('Details Inserted Successfully');</script>");
                }
                else
                {
                    throw new UserException("Details not inserted");
                }
            }
            catch (UserException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
            catch (SystemException ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
        }
    }
}