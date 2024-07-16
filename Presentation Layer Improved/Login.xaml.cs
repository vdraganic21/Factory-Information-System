using Business_Layer;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace Presentation_Layer_Improved
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Verify();
        }

        private void Verify()
        {
            RemoveErrors();
            var username = txtUsername.Text;
            var password = txtPassword.Password;

            if (username == "" && password == "")
            {
                SetErrorBorder(txtUsername);
                SetErrorBorder(txtPassword);
                ShowErrorMessage("Unesite korisničke podatke!");
                return;
            }

            if (username == "")
            {
                SetErrorBorder(txtUsername);
                ShowErrorMessage("Unesite korisničko ime!");
                return;
            }

            if (password == "")
            {
                SetErrorBorder(txtPassword);
                ShowErrorMessage("Unesite lozinku!");
                return;
            }

            if (LoginAuthenticator.IsValid(username, password))
            {
                LoginUser();
                return;
            }

            ShowErrorMessage("Pogrešni korisnički podaci!");
        }

        private void RemoveErrors()
        {
            txtUsername.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            txtUsername.BorderThickness = new Thickness(1);
            txtPassword.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            txtPassword.BorderThickness = new Thickness(1);

            lblErrorMessage.Content = "";
        }

        private void SetErrorBorder(TextBox txtBox)
        {
            txtBox.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            txtBox.BorderThickness = new Thickness(2);
        }
        private void SetErrorBorder(PasswordBox txtBox)
        {
            txtBox.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            txtBox.BorderThickness = new Thickness(2);
        }

        private void ShowErrorMessage(string message)
        {
            lblErrorMessage.Content = message;
        }

        private void LoginUser()
        {
            
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Verify();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
