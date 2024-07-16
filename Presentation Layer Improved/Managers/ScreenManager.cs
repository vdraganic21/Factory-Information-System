using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Presentation_Layer_Improved.Managers
{
    public static class ScreenManager
    {
        private static ContentControl _contentControl;

        public static void Initialize(ContentControl contentControl)
        {
            _contentControl = contentControl;
        }

        public static void LoadScreen(UserControl screen)
        {
            if (_contentControl != null)
            {
                _contentControl.Content = screen;
            }
        }
    }
}
