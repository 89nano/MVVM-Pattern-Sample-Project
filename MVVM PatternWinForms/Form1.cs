using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVM_Pattern_Sample_Project.Commands;
using MVVM_Pattern_Sample_Project.ViewModels;
using MVVM_Pattern_Sample_Project.Model;
using MVVM_Pattern_Sample_Project.Properties;
using MVVM_Pattern_Sample_Project.Repositories;
using MVVM_Pattern_Sample_Project.Services;
using Newtonsoft.Json;

namespace MVVM_PatternWinForms
{
    public partial class MiniNeoMedForm : Form
    {
        public MiniNeoMedForm(PatientViewModel patientViewModel, PatientDataRepository patientDataRepository)
        {
            InitializeComponent();
            _patientViewModel = patientViewModel;
            _patientDataRepository = patientDataRepository;
            _collectionsManagerService = new CollectionsManagerService();

            pbPatientImage.DataBindings.Add("ImageLocation", _patientViewModel, "PicturePath", true, DataSourceUpdateMode.OnPropertyChanged);

            lblFullNameSummary.DataBindings.Add("Text", _patientViewModel, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            lblAgeAndSexSummary.DataBindings.Add("Text", _patientViewModel, "AgeAndSexSummary", true, DataSourceUpdateMode.OnPropertyChanged);
            lblDiagnosticsSummary.DataBindings.Add("Text", _patientViewModel, "DiagnosticsSummary", true, DataSourceUpdateMode.OnPropertyChanged);
            lblAllergiesSummary.DataBindings.Add("Text", _patientViewModel, "AllergiesSummary", true, DataSourceUpdateMode.OnPropertyChanged);

            txtFullName.DataBindings.Add("Text", _patientViewModel, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpBirthDate.DataBindings.Add("Text", _patientViewModel, "BirthDate", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbSex.Items.AddRange(new []{"Male","Female"});
            cmbSex.DataBindings.Add("Text", _patientViewModel, "Sex", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNotes.DataBindings.Add("Text", _patientViewModel, "Notes", true, DataSourceUpdateMode.OnPropertyChanged);

            //Binding binding1 = new Binding("DataSource",_patientViewModel,"Diagnostics",true,DataSourceUpdateMode.OnPropertyChanged);

            lstboxDiagnostics.DataBindings.Add("DataSource", _patientViewModel, "Diagnostics", true, DataSourceUpdateMode.OnPropertyChanged);
            lstboxDiagnostics.DataBindings.Add("Text", _patientViewModel, "Diagnostics", true, DataSourceUpdateMode.OnPropertyChanged);
            
            lstboxAllergies.DataBindings.Add("DataSource", _patientViewModel, "Allergies", true, DataSourceUpdateMode.OnPropertyChanged);
            btnAddDiagnostics.DataBindings.Add("Text", _patientViewModel, "DiagnosticsAddButtonName");
            btnAddAllergies.DataBindings.Add("Text", _patientViewModel, "AllergiesAddButtonName");
        }

        public PatientViewModel PatientViewModel
        {
            get => _patientViewModel;
            set { _patientViewModel = value; }
        }

        private PatientViewModel _patientViewModel;
        private PatientDataRepository _patientDataRepository { get; set; }
        private CollectionsManagerService _collectionsManagerService { get; set; }


        private void btnAddDiagnostics_Click(object sender, EventArgs e)
        {
            var visible = lblDelimitedDiagnostics.Visible;
            if (!visible)
            {
                lblDelimitedDiagnostics.Visible = true;
                txtCommaDelimitedDiagnostics.Visible = true;
                _patientViewModel.DiagnosticsAddButtonName = "Done";
                txtCommaDelimitedDiagnostics.Focus();

            }
            else
            {
                var delimitedValues = txtCommaDelimitedDiagnostics.Text;
                if(!string.IsNullOrEmpty(delimitedValues))

                _patientViewModel.Diagnostics = _collectionsManagerService.
                    AddDelimitedValuesToCollection(delimitedValues, ',', _patientViewModel.Diagnostics);
                
                _patientViewModel.DiagnosticsAddButtonName = "Add";
                txtCommaDelimitedDiagnostics.Clear();
                lblDelimitedDiagnostics.Visible = false;
                txtCommaDelimitedDiagnostics.Visible = false;

            }


        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            _patientViewModel.UpdateModel();
            _patientDataRepository.WriteToJsonFile(_patientViewModel.Model);
           
            Close();
            
        }

        private void pbPatientImage_Click(object sender, EventArgs e)
        {
            _patientViewModel.OpenExplorerToChangePicture();
        }
    }
}
