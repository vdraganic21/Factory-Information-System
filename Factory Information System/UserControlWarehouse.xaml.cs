using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Factory_Information_System
{
    /// <summary>
    /// Interaction logic for UserControlWarehouse.xaml
    /// </summary>
    public partial class UserControlWarehouse : UserControl
    {
        public UserControlWarehouse()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            TabItem parentTabItem = this.Parent as TabItem;

            if (parentTabItem != null)
            {
                TabControl parentTabControl = parentTabItem.Parent as TabControl;

                if (parentTabControl != null)
                {
                    parentTabControl.Items.Remove(parentTabItem);
                }
            }
        }

        private void btnTraziZalihu_Click(object sender, RoutedEventArgs e)
        {
            ShowForbiddenAccessMessage();
        }

        private void btnObnavljanjeZalihe_Click(object sender, RoutedEventArgs e)
        {
            ShowForbiddenAccessMessage();
        }

        private void ShowForbiddenAccessMessage()
        {
            MessageBox.Show("Zabranjen pristup ovoj funkcionalnosti!", "Greška", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
