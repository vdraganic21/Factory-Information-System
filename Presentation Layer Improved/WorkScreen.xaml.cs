using Presentation_Layer_Improved.Managers;
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

namespace Presentation_Layer_Improved
{
    /// <summary>
    /// Interaction logic for WorkScreen.xaml
    /// </summary>
    public partial class WorkScreen : UserControl
    {
        private List<Border> tabList = new List<Border>();
        private UserControl settingsContent = new Settings();
        private UserControl homeContent = new HomeDashboard();
        private UserControl warehouseContent = new Warehouse();
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

            UnselectTabs();
            OpenTab(tabHome, homeContent);
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
    }
}
