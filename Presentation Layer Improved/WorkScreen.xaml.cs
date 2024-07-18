using Presentation_Layer_Improved.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Presentation_Layer_Improved
{
    public partial class WorkScreen : UserControl
    {
        private List<Border> tabList = new List<Border>();
        private UserControl settingsContent = new Settings();
        private UserControl homeContent = new HomeDashboard();
        private UserControl warehouseContent = new Warehouse();
        private UserControl invoiceContent = new InvoiceForm();
        private UserControl workOrderDetailsContent = new WorkOrderDetails();

        public WorkScreen()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            WorkScreenContentManager.Initialize(WorkScreenContent);

            tabList.Add(tabHome);
            tabList.Add(tabWarehouse);
            tabList.Add(tabSettings);
            tabList.Add(tabInvoice);
            tabList.Add(tabWorkOrderDetails);

            tabInvoice.Visibility = Visibility.Visible;

            UnselectTabs();
            OpenTab(tabHome, homeContent);
        }
        private void btnCloseInvoice_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tabInvoice.Visibility = Visibility.Collapsed;
            ShowHomeContent();
        }

        private void btnCloseWorkOrderDetails_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tabWorkOrderDetails.Visibility = Visibility.Collapsed;
            ShowHomeContent();
        }

        private void tabHome_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenTab(tabHome, homeContent);
        }

        private void tabWarehouse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenTab(tabWarehouse, warehouseContent);
        }

        private void tabSettings_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenTab(tabSettings, settingsContent);
        }

        private void tabInvoice_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenTab(tabInvoice, invoiceContent);
        }

        private void tabWorkOrderDetails_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenTab(tabWorkOrderDetails, workOrderDetailsContent);
        }

        private void OpenTab(Border tab, UserControl content)
        {
            UnselectTabs();
            SelectTab(tab);

            WorkScreenContentManager.LoadScreen(content);
        }

        private void SelectTab(Border tab)
        {
            BrushConverter converter = new BrushConverter();
            Brush backgroundBrush = (Brush)converter.ConvertFromString("#eee");

            tab.Background = backgroundBrush;
        }

        private void UnselectTabs()
        {
            BrushConverter converter = new BrushConverter();
            Brush backgroundBrush = (Brush)converter.ConvertFromString("#ccc");

            foreach (var tab in tabList)
            {
                tab.Background = backgroundBrush;
            }
        }

        private void ShowHomeContent()
        {
            UnselectTabs();
            SelectTab(tabHome);
            WorkScreenContentManager.LoadScreen(homeContent);
        }
    }
}
