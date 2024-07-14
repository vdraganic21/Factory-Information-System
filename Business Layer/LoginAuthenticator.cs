using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public static class LoginAuthenticator
    {
        public static bool IsValid(string username, string password) 
        {
            return (username == "IVAN HORVAT" && password == "lozinka123");
        }
    }
}
