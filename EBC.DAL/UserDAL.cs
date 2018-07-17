using EBC.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC.DAL
{
    public class UserDAL
    {
        //ElectricityInsert
        public static int ElectricityInsert(Electricity elect)
        {
            int recordsAffected = 0;

            try
            {
                SqlCommand cmd = DataConnection.GenerateCommand();
                cmd.CommandText = "SP_InsertRecords_EBC";

                cmd.Parameters.AddWithValue("@auserId", elect.customerId);
                cmd.Parameters.AddWithValue("@auserName", elect.customerName);
                cmd.Parameters.AddWithValue("@alastReading", elect.lastReading);
                cmd.Parameters.AddWithValue("@acurrentReading", elect.currentReading);
                cmd.Parameters.AddWithValue("@aunits", elect.units);
                cmd.Parameters.AddWithValue("@aprice", elect.price);

                cmd.Connection.Open();
                recordsAffected = cmd.ExecuteNonQuery();
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

            return recordsAffected;
        }

        //ElectricitySearch
        public static Electricity ElectricitySearch(int id)
        {
            Electricity elect = null;

            try
            {
                SqlCommand cmd = DataConnection.GenerateCommand();
                cmd.CommandText = "SP_SearchRecord_EBC";

                cmd.Parameters.AddWithValue("@auserId", id);

                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    elect = new Electricity();
                    elect.customerId = Convert.ToInt32(dr["userId"]);
                    elect.customerName = dr["userName"].ToString();
                    elect.lastReading = Convert.ToInt32(dr["lastReading"]);
                    elect.currentReading = Convert.ToInt32(dr["currentReading"]);                    
                    elect.units = Convert.ToInt32(dr["units"]);
                    elect.price = Convert.ToDecimal(dr["price"]);
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

            return elect;
        }

    }
}
