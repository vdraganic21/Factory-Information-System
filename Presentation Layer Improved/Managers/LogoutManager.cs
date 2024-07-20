using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Presentation_Layer_Improved.Managers
{
    public static class LogoutManager
    {
        public static void Logout() 
        {
            Application.Current.Shutdown();
        }
    }
}
