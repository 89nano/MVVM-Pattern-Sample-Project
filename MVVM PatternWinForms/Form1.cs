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
        public MiniNeoMedForm(PatientViewModel patientViewModel, PatientDataRepository patientDataRepository,
            PatientModel patientModel)
        {
            InitializeComponent();
            _patientViewModel = patientViewModel;
            _patientDataRepository = patientDataRepository;

            pbPatientImage.DataBindings.Add("Text", _patientViewModel, "PicturePath", true, DataSourceUpdateMode.OnPropertyChanged);
            pbPatientImage.ImageLocation = _patientViewModel.PicturePath;

            lblFullNameSummary.DataBindings.Add("Text", _patientViewModel, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            lblAgeAndSexSummary.DataBindings.Add("Text", _patientViewModel, "AgeAndSexSummary", true, DataSourceUpdateMode.OnPropertyChanged);
            lblDiagnosticsSummary.DataBindings.Add("Text", _patientViewModel, "DiagnosticsSummary", true, DataSourceUpdateMode.OnPropertyChanged);
            lblAllergiesSummary.DataBindings.Add("Text", _patientViewModel, "AllergiesSummary", true, DataSourceUpdateMode.OnPropertyChanged);

            txtFullName.DataBindings.Add("Text", _patientViewModel, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpBirthDate.DataBindings.Add("Text", _patientViewModel, "BirthDate", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbSex.Items.AddRange(new []{"Male","Female"});
            cmbSex.DataBindings.Add("Text", _patientViewModel, "Sex", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNotes.DataBindings.Add("Text", _patientViewModel, "Notes", true, DataSourceUpdateMode.OnPropertyChanged);

            lstboxDiagnostics.DataBindings.Add("Text", _patientViewModel, "Diagnostics", false, DataSourceUpdateMode.OnPropertyChanged);
            lstboxDiagnostics.DataSource = _patientViewModel.Diagnostics;
            lstboxAllergies.DataBindings.Add("Text", _patientViewModel, "Allergies", true, DataSourceUpdateMode.OnPropertyChanged);
            lstboxAllergies.DataSource = _patientViewModel.Allergies;

        }

        public PatientViewModel PatientViewModel
        {
            get => _patientViewModel;
            set { _patientViewModel = value; }
        }

        private PatientViewModel _patientViewModel;
        private PatientDataRepository _patientDataRepository { get; set; }
      
    }
}
