using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC.Exception
{
    public class UserException : ApplicationException
    {
        public UserException() : base()
        {

        }
        public UserException(string message) : base(message)
        {

        }
    }
}
