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
    public class UserBLL
    {
        public static int ElectricityInsert(Electricity elect)
        {
            int recordsAffected = 0;

            try
            {
                recordsAffected = UserDAL.ElectricityInsert(elect);
            }
            catch (UserException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }

            return recordsAffected;
        }


        public static Electricity ElectricitySearch(int id)
        {
            Electricity elect = null;

            try
            {
                elect = UserDAL.ElectricitySearch(id);
            }
            catch (UserException ex)
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
