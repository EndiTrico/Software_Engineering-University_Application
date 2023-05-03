using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public class InvalidLoginInfoException : Exception
    {
        public InvalidLoginInfoException(string message) : base("Invalid Credentials!") { }
    }
}