using Business_Layer;
using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for UserControlInvoice.xaml
    /// </summary>
    public partial class UserControlInvoice : UserControl
    {
        ProductService service;
        ObservableCollection<Product> stavke = new ObservableCollection<Product>();
        public UserControlInvoice()
        {
            InitializeComponent();

            this.service = new ProductService();
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

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
            }
        }

        private void btnUkloni_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dgvStavke.SelectedItem as Product;

            if (selectedItem == null) return;

            stavke.Remove(selectedItem);

            ReloadStavke();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dgvProizvodi.SelectedItem as Product;

            if (selectedItem == null) return;

            stavke.Add(selectedItem);

            ReloadStavke();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dgvProizvodi.ItemsSource = service.GetAll();
        }

        private void ReloadStavke()
        {
            dgvStavke.ItemsSource = stavke;
            
        }
    }
}
