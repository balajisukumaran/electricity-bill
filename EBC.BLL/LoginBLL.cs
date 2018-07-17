using EBC.DAL;
using EBC.Entity;
using EBC.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC.BLL
{
    public class LoginBLL
    {
        public static string ValidateLogin(LoginUser user)
        {
            string userName = "";

            try
            {
                userName = LoginDAL.ValidateLogin(user);
            }
            catch (UserException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }

            return userName;
        }
    }
}
