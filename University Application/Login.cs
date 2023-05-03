using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public interface Login
    {
        bool isUsernameAndPasswordValid(string username, string password);
    }
}