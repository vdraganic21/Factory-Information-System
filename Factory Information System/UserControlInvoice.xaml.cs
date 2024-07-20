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
        private List<OrganizationSubject> subjects = new OrganizationSubjectService().GetAll();
        private ProductService service;
        private ObservableCollection<Product> stavke = new ObservableCollection<Product>();
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
                ValidateSenderName();
                ValidateSenderId();
                ValidateReceiverName();
                ValidateReceiverId();

                DateTime parsedDate;

                DateParser.ParseDate(txtDatumKreiranja.Text);
                DateParser.ParseDate(txtDatumValjanosti.Text);
            }
            catch 
            {
                MessageBox.Show("Pogrešan unos!", "Greška", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void ValidateSenderId()
        {
            var senderId = txtPosiljateljSifra.Text;

            if (senderId == "") return;

            OrganizationSubject subject = subjects.FirstOrDefault(x => x.Id.Contains(senderId));

            if (subject == null) throw new Exception();

            txtPosiljateljNaziv.Text = subject.Name;
            txtPosiljateljSifra.Text = subject.Id;
        }

        private void ValidateReceiverName()
        {
            var receiverName = txtPrimateljNaziv.Text;

            if (receiverName == "") return;

            OrganizationSubject subject = subjects.FirstOrDefault(x => x.Name.Contains(receiverName));

            if (subject == null) throw new Exception();

            txtPrimateljSifra.Text = subject.Id;
            txtPrimateljNaziv.Text = subject.Name;
        }
        private void ValidateReceiverId()
        {
            var receiverId = txtPrimateljSifra.Text;

            if (receiverId == "") return;

            OrganizationSubject subject = subjects.FirstOrDefault(x => x.Id.Contains(receiverId));

            if (subject == null) throw new Exception();

            txtPrimateljNaziv.Text = subject.Name;
            txtPrimateljSifra.Text = subject.Id;
        }

        private void ValidateSenderName()
        {
            var senderName = txtPosiljateljNaziv.Text;

            if (senderName == "") return;

            OrganizationSubject subject = subjects.FirstOrDefault(x => x.Name.Contains(senderName));

            if (subject == null) throw new Exception();

            txtPosiljateljSifra.Text = subject.Id;
            txtPosiljateljNaziv.Text = subject.Name;

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

        private void btnDropdown_Click(object sender, RoutedEventArgs e)
        {
            btnPrint.ContextMenu.IsOpen = true;
        }

        private void PrintOption_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Greška!");
        }
        private void PrintOptionCorrect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uspješno!");
        }
    }
}
