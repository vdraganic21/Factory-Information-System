﻿using Business_Layer;
using Business_Layer.Entities;
using Business_Layer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Presentation_Layer_Improved
{
    /// <summary>
    /// Interaction logic for HomeDashboard.xaml
    /// </summary>
    public partial class HomeDashboard : UserControl, INotifyPropertyChanged
    {
        WorkScreen parentScreen;
        private WorkOrderService service = new WorkOrderService();

        private List<WorkOrder> filteredDocuments;
        public List<WorkOrder> FilteredDocuments
        {
            get { return filteredDocuments; }
            set
            {
                filteredDocuments = value;
                OnPropertyChanged();
            }
        }

        private List<String> documentTypes = new DocumentTypeService().GetAll();

        public HomeDashboard(WorkScreen parentScreen)
        {
            InitializeComponent();
            DataContext = this;
            this.parentScreen = parentScreen;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDocumentSearch();

            FilterDocuments();

        }

        private void LoadDocumentSearch()
        {
            cbDocumentSearch.ItemsSource = documentTypes;
            cbDocumentSearch.SelectedIndex = 0;
        }

        private void LoadFilterDefaults()
        {
            cbDocumentType.ItemsSource = documentTypes;
            cbDocumentType.Text = "";

            filterOptions.Visibility = Visibility.Collapsed;

            DateTime oneWeekBeforeToday = DateTime.Now.AddDays(-7);
            txtRadniNalogDatumOd.Text = oneWeekBeforeToday.ToString("dd.MM.yyyy.");

            cbSortOption.ItemsSource = new List<string>
            {
                "datumu kreiranja (uzlazno)",
                "datumu kreiranja (silazno)"
            };
            cbSortOption.SelectedIndex = 0;

            txtRadniNalogDatumDo.Text = "";
            txtPocetniTerminOd.Text = "";
            txtPocetniTerminDo.Text = "";
            txtKrajnjiTerminOd.Text = "";
            txtKrajnjiTerminDo.Text = "";
            txtWorkOrderId.Text = "";
            txtOrderId.Text = "";
            txtProduct.Text = "";
            txtBuyer.Text = "";

            ShowErrorMessage("");

        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            FilterDocuments();
        }

        private void FilterDocuments()
        {
            if (!FilterIsValid()) return;

            FilteredDocuments = GetFilteredDocuments();
        }

        private List<WorkOrder> GetFilteredDocuments()
        {
            var filteredDocuments = service.GetAll();

            if (cbDocumentType.Text != "057 - Radni nalog") filteredDocuments = new List<WorkOrder>();

            filteredDocuments = filteredDocuments
                .Where(wo => wo.RN.Contains(txtWorkOrderId.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            filteredDocuments = filteredDocuments
                .Where(wo => wo.Narudzba.Contains(txtOrderId.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            filteredDocuments = filteredDocuments
                .Where(wo => wo.Proizvod.Contains(txtProduct.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (txtBuyer.Text != "") filteredDocuments = new List<WorkOrder>();

            DateTime? radniNalogDatumOd = DateParser.ParseDate(txtRadniNalogDatumOd.Text);
            DateTime? radniNalogDatumDo = DateParser.ParseDate(txtRadniNalogDatumDo.Text);
            DateTime? pocetniTerminOd = DateParser.ParseDate(txtPocetniTerminOd.Text);
            DateTime? pocetniTerminDo = DateParser.ParseDate(txtPocetniTerminDo.Text);
            DateTime? krajnjiTerminOd = DateParser.ParseDate(txtKrajnjiTerminOd.Text);
            DateTime? krajnjiTerminDo = DateParser.ParseDate(txtKrajnjiTerminDo.Text);

            if (radniNalogDatumOd != null)
                filteredDocuments = filteredDocuments.Where(wo => wo.Datum.Date >= radniNalogDatumOd.Value.Date).ToList();

            if (radniNalogDatumDo != null)
                filteredDocuments = filteredDocuments.Where(wo => wo.Datum.Date <= radniNalogDatumDo.Value.Date).ToList();

            if (pocetniTerminOd != null)
                filteredDocuments = filteredDocuments.Where(wo => wo.PocTermin.Date >= pocetniTerminOd.Value.Date).ToList();

            if (pocetniTerminDo != null)
                filteredDocuments = filteredDocuments.Where(wo => wo.PocTermin.Date <= pocetniTerminDo.Value.Date).ToList();

            if (krajnjiTerminOd != null)
                filteredDocuments = filteredDocuments.Where(wo => wo.KraTermin.Date >= krajnjiTerminOd.Value.Date).ToList();

            if (krajnjiTerminDo != null)
                filteredDocuments = filteredDocuments.Where(wo => wo.KraTermin.Date <= krajnjiTerminDo.Value.Date).ToList();

            filteredDocuments = ApplySort(filteredDocuments);

            return filteredDocuments;
        }

        private List<WorkOrder> ApplySort(List<WorkOrder> documents)
        {
            string selectedSortOption = cbSortOption.SelectedItem.ToString();

            switch (selectedSortOption)
            {
                case "datumu kreiranja (uzlazno)":
                    return documents.OrderBy(doc => doc.Datum).ToList();

                case "datumu kreiranja (silazno)":
                    return documents.OrderByDescending(doc => doc.Datum).ToList();

                default:
                    return documents;
            }
        }

        private bool FilterIsValid()
        {
            if (cbDocumentType.Text != "057 - Radni nalog")
            {
                filterOptions.Visibility = Visibility.Collapsed;
                return false;
            }
            filterOptions.Visibility = Visibility.Visible;

            var dateTextBoxes = new List<TextBox>()
            {
                txtRadniNalogDatumOd,
                txtRadniNalogDatumDo,
                txtPocetniTerminOd,
                txtPocetniTerminDo,
                txtKrajnjiTerminOd,
                txtKrajnjiTerminDo
            };

            foreach (var dateTextBox in dateTextBoxes)
            {
                try
                {
                    DateParser.ParseDate(dateTextBox.Text);
                    dateTextBox.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ABADB3"));
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Datum mora biti u formatu dd.MM.yyyy!");
                    dateTextBox.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E62A2A"));
                }
            }

            DateTime? radniNalogDatumOd;
            DateTime? radniNalogDatumDo;
            DateTime? pocetniTerminOd;
            DateTime? pocetniTerminDo;
            DateTime? krajnjiTerminOd;
            DateTime? krajnjiTerminDo;

            try
            {
                radniNalogDatumOd = DateParser.ParseDate(txtRadniNalogDatumOd.Text);
                radniNalogDatumDo = DateParser.ParseDate(txtRadniNalogDatumDo.Text);
                pocetniTerminOd = DateParser.ParseDate(txtPocetniTerminOd.Text);
                pocetniTerminDo = DateParser.ParseDate(txtPocetniTerminDo.Text);
                krajnjiTerminOd = DateParser.ParseDate(txtKrajnjiTerminOd.Text);
                krajnjiTerminDo = DateParser.ParseDate(txtKrajnjiTerminDo.Text);
            }
            catch (Exception ex)
            {
                return false;
            }
            

            if (radniNalogDatumOd != null && radniNalogDatumDo != null)
            {
                if (radniNalogDatumOd > radniNalogDatumDo)
                {
                    ShowErrorMessage("Pogrešan poredak datuma kreiranja!");
                    return false;
                }
            }
            if (pocetniTerminOd != null && pocetniTerminDo != null)
            {
                if (pocetniTerminOd > pocetniTerminDo)
                {
                    ShowErrorMessage("Pogrešan poredak datuma početnog termina!");
                    return false;
                }
            }

            if (krajnjiTerminOd != null && krajnjiTerminDo != null)
            {
                if (krajnjiTerminOd > krajnjiTerminDo)
                {
                    ShowErrorMessage("Pogrešan poredak datuma krajnjeg termina!");
                    return false;
                }
            }

            ShowErrorMessage("");
            return true;
        }

        private void ShowErrorMessage(string message)
        {
            lblFilterErrorMessage.Content = message;
        }
        private void InputElement_LostFocus(object sender, RoutedEventArgs e)
        {
            FilterIsValid();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnRefreshFilter_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LoadFilterDefaults();
            FilterIsValid();
        }

        private void btnCreateDocument_Click(object sender, RoutedEventArgs e)
        {
            AutofillNewDocumentSearch();
            AutofillNewDocumentType();

            VerifyNewDocumentChoice();

            if (IsNewDocumentChoiceValid())
            { 
                if (cbDocumentSearch.Text == "D57 - Dostavnica") parentScreen.OpenInvoice();
            }

        }

        private void cbDocumentSearch_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                btnCreateDocument.Focus();

                AutofillNewDocumentSearch();

                VerifyNewDocumentChoice();
            }
        }

        private void cbDocumentType_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Tab)
            {
                AutofillNewDocumentType();

                txtWorkOrderId.Focus();
            }
        }

        private void VerifyNewDocumentChoice()
        {

            if (IsNewDocumentChoiceValid())
            {
                lblNewDocumentErrorMessage.Text = "";
                return;
            }

            lblNewDocumentErrorMessage.Text = "Traženi dokument ne postoji!";
        }

        private bool IsNewDocumentChoiceValid()
        {
            var newDocument = cbDocumentSearch.Text;

            if (newDocument == "") return false;

            if (!documentTypes.Exists(d => d.Equals(newDocument))) return false;

            return true;
        }

        private void cbDocumentSearch_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            AutofillNewDocumentSearch();
            VerifyNewDocumentChoice();
        }

        private void cbDocumentSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AutofillNewDocumentSearch();
            VerifyNewDocumentChoice();
        }

        private void AutofillNewDocumentSearch()
        {
            var searchedDocument = cbDocumentSearch.Text;
            var possibleMatch = documentTypes.FirstOrDefault(d => d.Contains(searchedDocument));

            if (possibleMatch != null)
            {
                cbDocumentSearch.Text = possibleMatch;
            }
        }

        private void AutofillNewDocumentType()
        {
            var searchedDocument = cbDocumentType.Text;
            var possibleMatch = documentTypes.FirstOrDefault(d => d.Contains(searchedDocument));

            if (possibleMatch != null)
            {
                cbDocumentType.Text = possibleMatch;
            }
        }

        private void OpenInvoice(object sender, MouseButtonEventArgs e)
        {
            parentScreen.OpenInvoice();
        }
        private void OpenWorkOrderDetails(object sender, MouseButtonEventArgs e)
        {
            parentScreen.OpenWorkOrderDetails();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LoadFilterDefaults();
        }
    }
}
