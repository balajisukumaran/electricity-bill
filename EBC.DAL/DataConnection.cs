using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC.DAL
{
    public class DataConnection
    {
        public static SqlCommand GenerateCommand()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }

            return cmd;
        }
    }
}
