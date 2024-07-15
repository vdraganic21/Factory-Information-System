using Business_Layer;
using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Factory_Information_System
{
    public partial class UserControlWarehouse : UserControl
    {
        StorageItemStatusService service;

        public UserControlWarehouse()
        {
            InitializeComponent();

            this.service = new StorageItemStatusService();

            cbSifra.ItemsSource = service.GetAllIds();
            cbNaziv.ItemsSource = service.GetAllNames();
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

        private void btnTraziZalihu_Click(object sender, RoutedEventArgs e)
        {
            ShowForbiddenAccessMessage();
        }

        private void btnObnavljanjeZalihe_Click(object sender, RoutedEventArgs e)
        {
            ShowForbiddenAccessMessage();
        }

        private void ShowForbiddenAccessMessage()
        {
            MessageBox.Show("Zabranjen pristup ovoj funkcionalnosti!", "Greška", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void cbSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                SearchById();
            }
        }

        private void cbNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                SearchByName();
            }
        }

        private void SearchById()
        {
            string selectedId = cbSifra.Text;

            if (!string.IsNullOrEmpty(selectedId))
            {
                var selectedItem = service.GetStorageItemStatusById(selectedId);

                if (selectedItem == null)
                {
                    ShowItemNotFoundMessage();
                    return;
                }

                PopulateForm(selectedItem);
            }
        }

        private void PopulateForm(StorageItemStatus item)
        {
            cbNaziv.Text = item.name;
            cbSifra.Text = item.id;

            txtMinimalnaZaliha.Text = item.minimalSupply.ToString();

            SetLeftovers(item.statuses);

            SetTotalSupply(item.statuses);

            dgvZalihaPoSkladistima.ItemsSource = item.statuses;

            dgvZalihaPoSkladistima.SelectedIndex = 0;

            SetDeliveries();
        }

        private void SetDeliveries()
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txt4.Text = "0";
            txt5.Text = "0";
            txt6.Text = "0";
            txt7.Text = txtIzabranoSkladiste.Text;
            txt8.Text = "0";
            txt9.Text = "0";
            txt10.Text = "0";
            txt11.Text = "0";
            txt12.Text = txtIzabranoSkladiste.Text;
        }

        private void SetTotalSupply(List<WarehouseStatus> statuses)
        {
            float ukupnaZaliha = 0;

            foreach (var status in statuses)
            {
                ukupnaZaliha += status.supply;
            }

            txtUkupnaZaliha.Text = ukupnaZaliha.ToString();

        }

        private void SetLeftovers(List<WarehouseStatus> statuses)
        {
            float slobodnaZaliha = 0;

            foreach (var status in statuses)
            {
                slobodnaZaliha += status.leftover;
            }

            txtSlobodnaZaliha.Text = slobodnaZaliha.ToString();
        }

        private void ShowItemNotFoundMessage()
        {
            MessageBox.Show("Tražena zaliha nije pronađena", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void SearchByName()
        {
            string selectedName = cbNaziv.Text;

            if (!string.IsNullOrEmpty(selectedName))
            {
                var selectedItem = service.GetStorageItemStatusByName(selectedName);

                if (selectedItem == null)
                {
                    ShowItemNotFoundMessage();
                    return;
                }

                PopulateForm(selectedItem);
            }
        }


        private void dgvZalihaPoSkladistima_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStatus = dgvZalihaPoSkladistima.SelectedItem as WarehouseStatus;

            if (selectedStatus == null) return;

            txtIzabranoSkladiste.Text = selectedStatus.supply.ToString();
            txtSlobodnaZalihaIzabranogSkladista.Text = selectedStatus.leftover.ToString();
            float ostalaSkladista = (float.Parse(txtUkupnaZaliha.Text) - float.Parse(txtIzabranoSkladiste.Text));
            txtOstalaSkladista.Text = ostalaSkladista.ToString();
        }
    }
}
