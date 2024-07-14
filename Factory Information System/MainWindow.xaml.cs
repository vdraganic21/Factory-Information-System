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
            InitializeMenuBar();
        }

        private void InitializeMenuBar()
        {
            string[] menuItems = { "Postavke", "Narudžbe", "Roba", "Proizvodnja", "Novac" };

            foreach (string menuItemText in menuItems)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.Header = menuItemText;

                string[] documentGroups = GetDocumentGroups(menuItemText);

                foreach (string groupText in documentGroups)
                {
                    MenuItem groupItem = new MenuItem();
                    groupItem.Header = groupText;

                    string[] documentTypes = GetDocumentTypes(groupText);

                    foreach (string typeText in documentTypes)
                    {
                        MenuItem typeItem = new MenuItem();
                        typeItem.Header = typeText;
                        typeItem.Click += DocumentMenuItem_Click;

                        groupItem.Items.Add(typeItem);
                    }

                    menuItem.Items.Add(groupItem);
                }

                menuBar.Items.Add(menuItem);
            }
        }

        private string[] GetDocumentGroups(string menuName)
        {
            switch (menuName)
            {
                case "Postavke":
                    return new string[] { "Settings Group 1", "Settings Group 2" };
                case "Narudžbe":
                    return new string[] { "Orders Group 1", "Orders Group 2" };
                case "Roba":
                    return new string[] { "Goods Group 1", "Goods Group 2" };
                case "Proizvodnja":
                    return new string[] { "Production Group 1", "Production Group 2" };
                case "Novac":
                    return new string[] { "Money Group 1", "Money Group 2" };
                default:
                    return new string[] { };
            }
        }

        private string[] GetDocumentTypes(string groupName)
        {
            switch (groupName)
            {
                case "Settings Group 1":
                    return new string[] { "Settings Doc 1", "Settings Doc 2" };
                case "Settings Group 2":
                    return new string[] { "Settings Doc 3", "Settings Doc 4" };
                case "Orders Group 1":
                    return new string[] { "Order Doc 1", "Order Doc 2" };
                case "Orders Group 2":
                    return new string[] { "Order Doc 3", "Order Doc 4" };
                case "Goods Group 1":
                    return new string[] { "Goods Doc 1", "Goods Doc 2" };
                case "Goods Group 2":
                    return new string[] { "Goods Doc 3", "Goods Doc 4" };
                case "Production Group 1":
                    return new string[] { "Production Doc 1", "Production Doc 2" };
                case "Production Group 2":
                    return new string[] { "Production Doc 3", "Production Doc 4" };
                case "Money Group 1":
                    return new string[] { "Money Doc 1", "Money Doc 2" };
                case "Money Group 2":
                    return new string[] { "Money Doc 3", "Money Doc 4" };
                default:
                    return new string[] { };
            }
        }

        private void DocumentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                string documentName = menuItem.Header.ToString();
                MessageBox.Show($"Selected document: {documentName}", "Document Selection");
            }
        }
    }
}
