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
using System.Windows.Shapes;

namespace Factory_Information_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DocumentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zabranjen pristup!", "Greška", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void PregledZaliha_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTab = new TabItem();
            newTab.Header = "Pregled zaliha";
            newTab.Content = new UserControlWarehouse();
            MainTabControl.Items.Add(newTab);
            MainTabControl.SelectedItem = newTab;
        }

        private void RadniNalogClick_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTab = new TabItem();
            newTab.Header = "Pregled radnih naloga";
            newTab.Content = new UserControlWorkOrder();
            MainTabControl.Items.Add(newTab);
            MainTabControl.SelectedItem = newTab;
        }

        private void Dostavnica_Click(object sender, RoutedEventArgs e)
        {
            TabItem newTab = new TabItem();
            newTab.Header = "D57 - Dostavnica";
            newTab.Content = new UserControlInvoice();
            MainTabControl.Items.Add(newTab);
            MainTabControl.SelectedItem = newTab;
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
