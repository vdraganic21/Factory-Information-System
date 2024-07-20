using Business_Layer;
using Business_Layer.Entities;
using Business_Layer.Services;
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

namespace Factory_Information_System
{
    /// <summary>
    /// Interaction logic for UserControlWorkOrder.xaml
    /// </summary>
    public partial class UserControlWorkOrder : UserControl
    {
        WorkOrderService service;
        public UserControlWorkOrder()
        {
            InitializeComponent();

            service = new WorkOrderService();
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

        private void dgvRadniNalozi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillComponentList();
        }

        private void FillComponentList()
        {
            var selectedWorkOrder = dgvRadniNalozi.SelectedItem as WorkOrder;
            if (selectedWorkOrder != null)
            {
                dgvSastavnica.ItemsSource = selectedWorkOrder.ComponentListItems;
            }
            else
            {
                dgvSastavnica.ItemsSource = null;
            }

            dgvSastavnica.SelectedIndex = 0;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchForWorkOrders();
            }
        }

        private void SearchForWorkOrders()
        {
            try
            {
                var filteredWorkOrders = service.GetAll();

                if (txtPrimatelj.Text.Length > 0)
                    filteredWorkOrders = null;

                if (txtProizvod.Text.Length > 0)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.Proizvod.Contains(txtProizvod.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                if (txtKupac.Text.Length > 0)
                    filteredWorkOrders = null;

                if (txtNarudzbaKupca.Text.Length > 0)
                    filteredWorkOrders = null;

                if (txtNarudzbaKupcaId.Text.Length > 0)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.Narudzba.Contains(txtNarudzbaKupcaId.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                if (txtRadniNalog.Text.Length > 0)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.Naziv.Contains(txtRadniNalog.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                if (txtRadniNalogId.Text.Length > 0)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.RN.Contains(txtRadniNalogId.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                DateTime? radniNalogDatumOd = DateParser.ParseDate(txtRadniNalogDatumOd.Text);
                DateTime? radniNalogDatumDo = DateParser.ParseDate(txtRadniNalogDatumDo.Text);
                DateTime? pocetniTerminOd = DateParser.ParseDate(txtPocetniTerminOd.Text);
                DateTime? pocetniTerminDo = DateParser.ParseDate(txtPcoetniTerminDo.Text);
                DateTime? krajnjiTerminOd = DateParser.ParseDate(txtKrajnjiTerminOd.Text);
                DateTime? krajnjiTerminDo = DateParser.ParseDate(txtKrajnjiTerminDo.Text);

                if (radniNalogDatumOd != null && radniNalogDatumDo != null) 
                {
                    if (radniNalogDatumOd > radniNalogDatumDo) throw new Exception();
                }

                if (pocetniTerminOd != null && pocetniTerminDo != null)
                {
                    if (pocetniTerminOd > pocetniTerminDo) throw new Exception();
                }

                if (krajnjiTerminOd != null && krajnjiTerminDo != null)
                {
                    if (krajnjiTerminOd > krajnjiTerminDo) throw new Exception();
                }

                if (radniNalogDatumOd != null)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.Datum.Date >= radniNalogDatumOd.Value.Date).ToList();

                if (radniNalogDatumDo != null)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.Datum.Date <= radniNalogDatumDo.Value.Date).ToList();

                if (pocetniTerminOd != null)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.PocTermin.Date >= pocetniTerminOd.Value.Date).ToList();

                if (pocetniTerminDo != null)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.PocTermin.Date <= pocetniTerminDo.Value.Date).ToList();

                if (krajnjiTerminOd != null)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.KraTermin.Date >= krajnjiTerminOd.Value.Date).ToList();

                if (krajnjiTerminDo != null)
                    filteredWorkOrders = filteredWorkOrders.Where(wo => wo.KraTermin.Date <= krajnjiTerminDo.Value.Date).ToList();


                dgvRadniNalozi.ItemsSource = filteredWorkOrders;
            }
            catch
            {
                MessageBox.Show("Pogrešni podaci u filtru", "Greška", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
        }

    }
}
