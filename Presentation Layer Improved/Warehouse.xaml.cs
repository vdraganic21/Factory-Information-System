using Business_Layer;
using Business_Layer.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Presentation_Layer_Improved
{
    public partial class Warehouse : UserControl, INotifyPropertyChanged
    {
        private StorageItemStatusService service;
        private List<StorageItemStatus> loadedStorageItemStatuses;

        public List<StorageItemStatus> LoadedStorageItemStatuses
        {
            get { return loadedStorageItemStatuses; }
            set
            {
                loadedStorageItemStatuses = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Warehouse()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            service = new StorageItemStatusService();
            loadedStorageItemStatuses = new List<StorageItemStatus>();

            cbSort.ItemsSource = new List<string>
            {
                "nazivu (uzlazno)",
                "nazivu (silazno)",
                "količini (uzlazno)",
                "količini (silazno)"
            };
            cbSort.SelectedIndex = 0;

            var allNames = service.GetAllNames();
            var allIds = service.GetAllIds();
            var combinedList = allNames.Concat(allIds).ToList();

            cbSearch.ItemsSource = combinedList;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            LoadStatuses();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplySort();
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                LoadStatuses();
            }
        }

        private void LoadStatuses()
        {
            LoadedStorageItemStatuses = service.GetAll()
                .Where(item => item.name.Contains(cbSearch.Text) || item.id.Contains(cbSearch.Text))
                .ToList();
            ApplySort();
        }

        private void ApplySort()
        {
            switch (cbSort.SelectedItem.ToString())
            {
                case "nazivu (uzlazno)":
                    LoadedStorageItemStatuses = LoadedStorageItemStatuses.OrderBy(item => item.name).ToList();
                    break;
                case "nazivu (silazno)":
                    LoadedStorageItemStatuses = LoadedStorageItemStatuses.OrderByDescending(item => item.name).ToList();
                    break;
                case "količini (uzlazno)":
                    LoadedStorageItemStatuses = LoadedStorageItemStatuses.OrderBy(item => item.TotalSupply).ToList();
                    break;
                case "količini (silazno)":
                    LoadedStorageItemStatuses = LoadedStorageItemStatuses.OrderByDescending(item => item.TotalSupply).ToList();
                    break;
                default:
                    break;
            }
        }
    }
}
