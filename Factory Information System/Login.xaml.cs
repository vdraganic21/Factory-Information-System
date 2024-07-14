using Business_Layer;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadComboboxes();
        }

        private void LoadComboboxes()
        {
            cmbAutentifikacija.IsEnabled = false;
            cmbPoduzece.IsEnabled = false;

            List<String> authenticationMethods = new List<String>
            {
                "SQL Server Authentication"
            };

            List<String> companies = new List<String>
            {
                "99999 (Metal Factory(10.0.42.38))"
            };

            cmbAutentifikacija.ItemsSource = authenticationMethods;
            cmbAutentifikacija.SelectedIndex = 0;
            cmbPoduzece.ItemsSource = companies;
            cmbPoduzece.SelectedIndex = 0;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPrijaviSe_Click(object sender, RoutedEventArgs e)
        {
            string username = txtKorisnik.Text;
            string password = txtLozinka.Password;

            bool isValid = LoginAuthenticator.IsValid(username, password);

            if (!isValid)
            {
                //MessageBox.Show("Pogrešni podaci za prijavu!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                //return;
            }

            this.Hide();

            new MainWindow().ShowDialog();

            this.Close();
        }
    }
}
