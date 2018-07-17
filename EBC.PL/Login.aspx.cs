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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginUser user = new LoginUser();

                user.userName = txtUserName.Text;
                user.password = txtPassword.Text;

                string userName = LoginBLL.ValidateLogin(user);

                if (userName != "")
                {
                    Session["user"] = userName;
                    Response.Redirect("Welcome.aspx");
                }
                else
                    throw new UserException("UserName/Password is incorrect");
            }
            catch (UserException ex)
            {
                lblError.Text = ex.Message;
            }
            catch (SystemException ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
