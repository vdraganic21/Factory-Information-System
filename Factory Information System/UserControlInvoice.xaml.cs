using Business_Layer;
using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dgvProizvodi.ItemsSource = service.GetAll();
            txtDatumKreiranja.Text = DateTime.Now.ToString("dd.MM.yyyy.");
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
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                Verify();
            }
        }

        private void Verify()
        {
            try 
            {
                if (txtPosiljateljSifra.Text == "255") txtPosiljateljNaziv.Text = "Odjel Zavarene konstrukcije";
                if (txtPosiljateljNaziv.Text == "Odjel Zavarene konstrukcije") txtPosiljateljSifra.Text = "255";

                if (txtPrimateljSifra.Text == "4201-52") txtPrimateljNaziv.Text = "Metal Transport d.o.o.";
                if (txtPrimateljNaziv.Text == "Metal Transport d.o.o.") txtPrimateljSifra.Text = "4201-52";

                if (txtPosiljateljSifra.Text != "" && txtPosiljateljSifra.Text != "255") throw new Exception();
                if (txtPosiljateljNaziv.Text != "" && txtPosiljateljNaziv.Text != "Odjel Zavarene konstrukcije") throw new Exception();

                if (txtPrimateljSifra.Text != "" && txtPrimateljSifra.Text != "4201-52") throw new Exception();
                if (txtPrimateljNaziv.Text != "" && txtPrimateljNaziv.Text != "Metal Transport d.o.o.") throw new Exception();

                DateTime parsedDate;

                DateParser.ParseDate(txtDatumKreiranja.Text);
                DateParser.ParseDate(txtDatumValjanosti.Text);
            }
            catch 
            {
                MessageBox.Show("Pogrešan unos!", "Greška", MessageBoxButton.OK, MessageBoxImage.Information);
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

        

        private void ReloadStavke()
        {
            dgvStavke.ItemsSource = stavke;
        }

        private void txtIdent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                string ident = txtIdent.Text;
                dgvProizvodi.ItemsSource = service.GetAll().Where(p => p.Id.Contains(ident));
            }
        }
    }
}
