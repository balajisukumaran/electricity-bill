using EBC.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC.DAL
{
    public class LoginDAL
    {
        public static string ValidateLogin(LoginUser user)
        {
            string userName = "";

            try
            {
                SqlCommand cmd = DataConnection.GenerateCommand();
                cmd.CommandText = "SP_ValidateLogin_EBC";

                cmd.Parameters.AddWithValue("@auserName", user.userName);
                cmd.Parameters.AddWithValue("@apassword", user.password);

                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    userName = dr["userName"].ToString();
                }
                cmd.Connection.Close();
            }
            catch (SqlException ex)
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
