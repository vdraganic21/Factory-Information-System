using Business_Layer;
using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Presentation_Layer_Improved
{
    public partial class InvoiceForm : UserControl, INotifyPropertyChanged
    {
        private List<OrganizationSubject> subjects = new OrganizationSubjectService().GetAll();

        private List<Product> products = new ProductService().GetAll();
        private ObservableCollection<Product> selectedProducts = new ObservableCollection<Product>();
        public ObservableCollection<Product> SelectedProducts
        {
            get { return selectedProducts; }
            set
            {
                selectedProducts = value;
                OnPropertyChanged();
            }
        }

        public InvoiceForm()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtCreationDate.Text = DateTime.Now.ToString("dd.MM.yyyy.");
            txtExpirationDate.Text = DateTime.Now.AddDays(3).ToString("dd.MM.yyyy.");
        }

        private void SenderId_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAndAutocompleteSenderId();
        }

        private void SenderName_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAndAutocompleteSenderName();
        }

        private void ReceiverId_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAndAutocompleteReceiverId();
        }

        private void ReceiverName_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAndAutocompleteReceiverName();
        }

        private void CreationDate_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateCreationDate();
        }

        private void ExpirationDays_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateExpirationDays();
        }

        private void ExpirationDate_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateExpirationDate();
        }

        private void ExpirationDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

        private void ValidateAndAutocompleteSenderId()
        {
            string senderId = txtSenderId.Text;
            if (string.IsNullOrEmpty(senderId))
            {
                txtSenderName.Text = "";
                lblSenderError.Content = "";
                txtSenderId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtSenderName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                return;
            }

            var sender = subjects.FirstOrDefault(s => s.Id.IndexOf(senderId, StringComparison.OrdinalIgnoreCase) >= 0);

            if (sender != null)
            {
                txtSenderId.Text = sender.Id;
                txtSenderName.Text = sender.Name;
                lblSenderError.Content = "";
                txtSenderId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtSenderName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            }
            else
            {
                lblSenderError.Content = "Unesite ispravnu šifru pošiljatelja.";
                txtSenderId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        private void ValidateAndAutocompleteSenderName()
        {
            string senderName = txtSenderName.Text;
            if (string.IsNullOrEmpty(senderName))
            {
                txtSenderId.Text = "";
                lblSenderError.Content = "";
                txtSenderName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtSenderId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                return;
            }

            var sender = subjects.FirstOrDefault(s => s.Name.IndexOf(senderName, StringComparison.OrdinalIgnoreCase) >= 0);

            if (sender != null)
            {
                txtSenderId.Text = sender.Id;
                txtSenderName.Text = sender.Name;
                lblSenderError.Content = "";
                txtSenderName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtSenderId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            }
            else
            {
                lblSenderError.Content = "Unesite ispravno ime pošiljatelja!";
                txtSenderName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        private void ValidateAndAutocompleteReceiverId()
        {
            string receiverId = txtReceiverId.Text;
            if (string.IsNullOrEmpty(receiverId))
            {
                txtReceiverName.Text = "";
                lblReceiverError.Content = "";
                txtReceiverId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtReceiverName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                return;
            }

            var receiver = subjects.FirstOrDefault(s => s.Id.IndexOf(receiverId, StringComparison.OrdinalIgnoreCase) >= 0);

            if (receiver != null)
            {
                txtReceiverId.Text = receiver.Id;
                txtReceiverName.Text = receiver.Name;
                lblReceiverError.Content = "";
                txtReceiverId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtReceiverName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            }
            else
            {
                lblReceiverError.Content = "Unesite ispravnu šifru primatelja!";
                txtReceiverId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        private void ValidateAndAutocompleteReceiverName()
        {
            string receiverName = txtReceiverName.Text;
            if (string.IsNullOrEmpty(receiverName))
            {
                txtReceiverId.Text = "";
                lblReceiverError.Content = "";
                txtReceiverName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtReceiverId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                return;
            }

            var receiver = subjects.FirstOrDefault(s => s.Name.IndexOf(receiverName, StringComparison.OrdinalIgnoreCase) >= 0);

            if (receiver != null)
            {
                txtReceiverId.Text = receiver.Id;
                txtReceiverName.Text = receiver.Name;
                lblReceiverError.Content = "";
                txtReceiverName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtReceiverId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            }
            else
            {
                lblReceiverError.Content = "Unesite ispravno ime primatelja!";
                txtReceiverName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        private void ValidateCreationDate()
        {
            if (!DateTime.TryParseExact(txtCreationDate.Text, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out DateTime creationDate))
            {
                lblCreationDateError.Content = "Unesite ispravan datum formata dd.MM.yyyy.";
                txtCreationDate.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
            else
            {
                lblCreationDateError.Content = "";
                txtCreationDate.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                UpdateExpirationDate();
            }
        }

        private void ValidateExpirationDays()
        {
            if (int.TryParse(txtExpirationDays.Text, out int days))
            {
                if (days <= 0)
                {
                    days = 1;
                    txtExpirationDays.Text = days.ToString();
                }

                lblExpirationError.Content = "";
                txtExpirationDays.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                UpdateExpirationDate();
            }
            else
            {
                lblExpirationError.Content = "Unesite ispravan broj dana.";
                txtExpirationDays.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        private void ValidateExpirationDate()
        {
            if (!DateTime.TryParseExact(txtExpirationDate.Text, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out DateTime expirationDate))
            {
                lblExpirationError.Content = "Unesite ispravan datum formata dd.MM.yyyy.";
                txtExpirationDate.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
            else
            {
                lblExpirationError.Content = "";
                txtExpirationDate.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                UpdateExpirationDays();
            }
        }

        private void UpdateExpirationDate()
        {
            if (DateTime.TryParseExact(txtCreationDate.Text, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out DateTime creationDate) &&
                int.TryParse(txtExpirationDays.Text, out int days))
            {
                txtExpirationDate.Text = creationDate.AddDays(days).ToString("dd.MM.yyyy.");
            }
        }

        private void UpdateExpirationDays()
        {
            if (DateTime.TryParseExact(txtCreationDate.Text, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out DateTime creationDate) &&
                DateTime.TryParseExact(txtExpirationDate.Text, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out DateTime expirationDate))
            {
                txtExpirationDays.Text = (expirationDate - creationDate).Days.ToString();
            }
        }
        private void MoveToNextUIElement(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                var request = new TraversalRequest(FocusNavigationDirection.Next);
                (sender as UIElement)?.MoveFocus(request);
            }
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            string productId = txtProductId.Text;
            string productName = txtProductName.Text;
            if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
            {
                lblAddProductError.Content = "Unesite ispravnu količinu veću od 0.";
                return;
            }

            var product = products.FirstOrDefault(p => p.Id.Equals(productId) &&
                                                       p.Ime.Equals(productName));

            if (product != null)
            {
                var existingProduct = selectedProducts.FirstOrDefault(p => p.Id.Equals(productId));

                if (existingProduct != null)
                {
                    lblAddProductError.Content = "Proizvod je već na listi.";
                    return;
                }

                product.Kolicina = amount;
                selectedProducts.Add(product);
                lblAddProductError.Content = "";

                txtProductId.Text = "";
                txtProductName.Text = "";
                txtAmount.Text = "1";
            }
            else
            {
                lblAddProductError.Content = "Proizvod ne postoji.";
            }
        }
        private void txtAmount_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAmount();
        }

        private void Amount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

        private void ValidateAmount()
        {
            if (int.TryParse(txtAmount.Text, out int amount))
            {
                if (amount <= 0)
                {
                    txtAmount.Text = "1";
                    lblAddProductError.Content = "";
                    txtAmount.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                }
            }
            else
            {
                lblAddProductError.Content = "Unesite ispravan broj.";
                txtAmount.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }
        private void ProductId_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAndAutocompleteProductId();
        }

        private void ProductName_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidateAndAutocompleteProductName();
        }

        private void ValidateAndAutocompleteProductId()
        {
            string productId = txtProductId.Text;
            if (string.IsNullOrEmpty(productId))
            {
                txtProductName.Text = "";
                lblAddProductError.Content = "";
                txtProductId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtProductName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                return;
            }

            var product = products.FirstOrDefault(p => p.Id.IndexOf(productId, StringComparison.OrdinalIgnoreCase) >= 0);

            if (product != null)
            {
                txtProductId.Text = product.Id;
                txtProductName.Text = product.Ime;
                lblAddProductError.Content = "";
                txtProductId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtProductName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            }
            else
            {
                lblAddProductError.Content = "Unesite ispravnu šifru primatelja!"; 
                txtProductId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        private void ValidateAndAutocompleteProductName()
        {
            string productName = txtProductName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                txtProductId.Text = "";
                lblAddProductError.Content = "";
                txtProductName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtProductId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                return;
            }

            var product = products.FirstOrDefault(p => p.Ime.IndexOf(productName, StringComparison.OrdinalIgnoreCase) >= 0);

            if (product != null)
            {
                txtProductId.Text = product.Id;
                txtProductName.Text = product.Ime;
                lblAddProductError.Content = "";
                txtProductName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                txtProductId.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
            }
            else
            {
                lblAddProductError.Content = "Unesite ispravno ime primatelja!";
                txtProductName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void btnRemoveProduct_Click(object sender, MouseButtonEventArgs e)
        {
           var image = sender as Image;

            var product = image?.DataContext as Product;

            if (product != null)
            {
                SelectedProducts.Remove(product);
            }
        }

    }
}
