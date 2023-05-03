using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public interface Login
    {
        OleDbDataReader isUsernameAndPasswordValid(string username, string password);
    }
}