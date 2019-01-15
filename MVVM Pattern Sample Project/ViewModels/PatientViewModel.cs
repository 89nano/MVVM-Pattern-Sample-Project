using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Win32;
using MVVM_Pattern_Sample_Project.Commands;
using MVVM_Pattern_Sample_Project.Model;
using MVVM_Pattern_Sample_Project.Repositories;
using MVVM_Pattern_Sample_Project.Services;
using Newtonsoft.Json;

namespace MVVM_Pattern_Sample_Project.ViewModels
{
    public class PatientViewModel : INotifyPropertyChanged, IEqualityComparer<PatientModel>
    {


        public PatientViewModel()
        {
            _collectionsManagerService = new CollectionsManagerService();
            _patientDataRepository = new PatientDataRepository();
            PatientSummary = new ObservableCollection<PatientModel>();
            Diagnostics = new ObservableCollection<string>();
            Allergies = new ObservableCollection<string>();
            Model = new PatientModel();
            PicturePath = Path.GetFullPath(Environment.CurrentDirectory + "/Images");
            MyVisibility = Visibility.Hidden;
            LoadPatient();
            GenerateDiagnosticsSummaryText();
            GenerateAllergiesSummaryText();
            _closeAndSaveCommand = new DelegateCommand(a => SaveAndClose());
            _addDiagnosticsCommand = new DelegateCommand(b => AddDiagnostics());
            _removeDiagnosticsCommand = new DelegateCommand(c => RemoveDiagnostics());
            _addAllergiesCommand = new DelegateCommand(d => AddAllergies());
            _removeAllergiesCommand = new DelegateCommand(e => RemoveAllergies());
            _openExplorerToChangePictureCommand = new DelegateCommand(f => OpenExplorerToChangePicture());
            DiagnosticsAddButtonName = "Add";
            AllergiesAddButtonName = "Add";
            CommaDelimitedDiagnostics = string.Empty;

        }

        public void OpenExplorerToChangePicture()
        {
            var appImagesPath = Environment.CurrentDirectory + @"\Images";

            // Displays an OpenFileDialog so the user can select an image.  
            OpenFileDialog imagesOpenFileDialog = new OpenFileDialog();
            imagesOpenFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            imagesOpenFileDialog.Title = "Select an Image";
            imagesOpenFileDialog.Multiselect = false;
            imagesOpenFileDialog.InitialDirectory =
                Path.GetFullPath(appImagesPath);

            var result = imagesOpenFileDialog.ShowDialog();
            var selectedImagePath = string.Empty;
            var retrievedPathWithFileName = string.Empty;
            var imageName = PictureName;

            if (result.HasValue && result.Value)
            {
                //path includes name
                retrievedPathWithFileName = imagesOpenFileDialog.FileName;
                //gets path only
                selectedImagePath = retrievedPathWithFileName.Substring(0, retrievedPathWithFileName
                    .LastIndexOf(("\\"), StringComparison.Ordinal))
                    ;
                //get image name from path
                imageName = retrievedPathWithFileName.Substring(retrievedPathWithFileName
                    .LastIndexOf("\\", StringComparison.Ordinal) + 1);
            }

            //If selected and image outside of the app's image directory, copy that image
            //to the app's image directory
            if (selectedImagePath != Environment.CurrentDirectory + "images")
            {
                if (!string.IsNullOrEmpty(retrievedPathWithFileName))
                {
                    try
                    {
                        File.Copy(retrievedPathWithFileName, appImagesPath + "\\" + imageName);
                        PictureName = imageName;
                    }
                    catch (IOException e)
                    {
                        PictureName = imageName;
                    }
                }
            }
        }


        #region Properties

        private PatientDataRepository _patientDataRepository { get; }

        private PatientModel _model;
        public ObservableCollection<PatientModel> PatientSummary { get; set; }
        public ObservableCollection<string> Diagnostics { get; set; }

        public ObservableCollection<string> Allergies { get; set; }


        public PatientModel DeserializedPatientModel { get; set; }


        private string _fullName;
        private string _sex;
        private DateTime _birthDate;
        private int _age;
        private string _notes;
        private string _pictureName;
        private string _ageAndSexSummary;
        private string _diagnosticsSummary;
        private string _allergiesSummary;
        private string _picturePath;
        private Visibility _myVisibility;
        private DelegateCommand _closeAndSaveCommand;
        private DelegateCommand _addDiagnosticsCommand;
        private DelegateCommand _removeDiagnosticsCommand;
        private DelegateCommand _removeAllergiesCommand;
        private DelegateCommand _addAllergiesCommand;
        private DelegateCommand _openExplorerToChangePictureCommand;

        private string _diagnosticsAddButtonName;
        private string _allergiesAddButtonName;
        private string _commaDelimitedDiagnostics;
        private string _commaDelimitedAllergies;

        private int _diagnosticsListBoxSelectedIndex;
        private int _allergiesListBoxSelectedIndex;

        private readonly CollectionsManagerService _collectionsManagerService;

        public PatientModel Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));

            }
        }


        public string CommaDelimitedDiagnostics
        {
            get => _commaDelimitedDiagnostics;
            set
            {
                _commaDelimitedDiagnostics = value;
                OnPropertyChanged(nameof(CommaDelimitedDiagnostics));
            }
        }

        public string CommaDelimitedAllergies
        {
            get => _commaDelimitedAllergies;
            set
            {
                _commaDelimitedAllergies = value;
                OnPropertyChanged(nameof(CommaDelimitedAllergies));
            }
        }

        public Visibility MyVisibility
        {
            get => _myVisibility;
            set
            {
                _myVisibility = value;
                OnPropertyChanged(nameof(MyVisibility));
            }
        }

        public int DiagnosticsListBoxSelectedIndex
        {
            get => _diagnosticsListBoxSelectedIndex;
            set
            {
                _diagnosticsListBoxSelectedIndex = value;
                OnPropertyChanged(nameof(DiagnosticsListBoxSelectedIndex));
            }
        }

        public int AllergiesListBoxSelectedIndex
        {
            get => _allergiesListBoxSelectedIndex;
            set
            {
                _allergiesListBoxSelectedIndex = value;
                OnPropertyChanged(nameof(AllergiesListBoxSelectedIndex));
            }
        }


        public string AgeAndSexSummary
        {
            get => _ageAndSexSummary;
            set
            {
                if (!string.Equals(_ageAndSexSummary, value, StringComparison.Ordinal))
                    _ageAndSexSummary = value;
                OnPropertyChanged(nameof(AgeAndSexSummary));
            }

        }

        public string DiagnosticsSummary
        {
            get => _diagnosticsSummary;
            set
            {
                if (!string.Equals(_diagnosticsSummary, value, StringComparison.Ordinal))
                    _diagnosticsSummary = value;
                OnPropertyChanged(nameof(DiagnosticsSummary));
            }

        }

        public string AllergiesSummary
        {
            get => _allergiesSummary;
            set
            {
                if (!string.Equals(_allergiesSummary, value, StringComparison.Ordinal))
                    _allergiesSummary = value;
                OnPropertyChanged(nameof(AllergiesSummary));
            }

        }


        public string FullName
        {
            get => _fullName;

            set
            {
                if (value != null && _fullName != value)
                    _fullName = value;

                OnPropertyChanged(nameof(FullName));
                Model.FullName = _fullName;

            }
        }

        public string PicturePath
        {
            get => _picturePath + "/" + _pictureName;
            set => _picturePath = value;
        }

        public string PictureName
        {
            get => _pictureName;

            set
            {
                if (value != null && _pictureName != value)
                    _pictureName = value;
                OnPropertyChanged(nameof(PicturePath));

            }
        }

        public string BirthDate
        {
            get => _birthDate.ToString("yyyy-M-d");

            set
            {

                if (DateTime.TryParse(value, out _birthDate))
                {
                    _birthDate = DateTime.Parse(value);
                    CalculateAge(_birthDate);
                }

                OnPropertyChanged(nameof(BirthDate));

            }
        }

        public string Sex
        {
            get => _sex;
            set
            {
                if (_sex != value)
                    _sex = value;

                OnPropertyChanged(nameof(Sex));

                if (!string.IsNullOrEmpty(_sex) && _age != 0)
                    GenerateAgeAndSexText();

            }
        }

        public string DiagnosticsAddButtonName
        {
            get => _diagnosticsAddButtonName;
            set
            {
                _diagnosticsAddButtonName = value;
                OnPropertyChanged();
            }
        }

        public string AllergiesAddButtonName
        {
            get => _allergiesAddButtonName;
            set
            {
                _allergiesAddButtonName = value;
                OnPropertyChanged();
            }
        }

        public string Notes
        {
            get => _notes;
            set
            {
                if (value != null && _notes != value)
                    _notes = value;

                OnPropertyChanged(nameof(Notes));
            }
        }

        #region Commands

        public DelegateCommand SaveChangesAndCloseCommand => _closeAndSaveCommand;
        public DelegateCommand AddDiagnosticsCommand => _addDiagnosticsCommand;
        public DelegateCommand AddAllergiesCommand => _addAllergiesCommand;
        public DelegateCommand RemoveDiagnosticsCommand => _removeDiagnosticsCommand;
        public DelegateCommand RemoveAllergiesCommand => _removeAllergiesCommand;
        public DelegateCommand OpenExplorerToChangePictureCommand => _openExplorerToChangePictureCommand;


        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        enum YearMonthOrDay
        {
            Year,
            Month,
            Day
        }

        #endregion



        #region Methods

        public void LoadPatient()
        {

            string json = _patientDataRepository.ReadJsonFile();

            var patientDeserializedData = JsonConvert.DeserializeObject<PatientModel>(json);

            DeserializedPatientModel = patientDeserializedData;

            FullName = patientDeserializedData.FullName;
            PictureName = patientDeserializedData.PictureName;
            BirthDate = patientDeserializedData.BirthDate;
            Sex = patientDeserializedData.Sex;
            Notes = patientDeserializedData.Notes;


            foreach (var patientDiagnostic in patientDeserializedData.Diagnostics)
            {
                Diagnostics.Add(patientDiagnostic);
            }

            foreach (var patientallergy in patientDeserializedData.Allergies)
            {
                Allergies.Add(patientallergy);
            }

            DiagnosticsListBoxSelectedIndex = 0;

        }

        private void CalculateAge(DateTime birthDate)
        {

            var today = DateTime.UtcNow;
            var dateDifference = today - birthDate;
            var daysToYears = (float)(dateDifference.TotalDays / 365);
            var daysToMonths = (float)(dateDifference.TotalDays / 30.416);
            var yearMonthOrDay = YearMonthOrDay.Year;

            if (daysToYears >= 1)
            {
                _age = (int)daysToYears;
            }
            else if (daysToMonths >= 1)
            {
                _age = (int)(dateDifference.TotalDays / 30.416);
                yearMonthOrDay = YearMonthOrDay.Month;
            }

            else
            {
                _age = (int)dateDifference.TotalDays;
                yearMonthOrDay = YearMonthOrDay.Day;
            }


            if (!string.IsNullOrEmpty(_sex) && _age != 0)
                GenerateAgeAndSexText(yearMonthOrDay);

        }
        private void GenerateAgeAndSexText(YearMonthOrDay yearMonthOrDay = YearMonthOrDay.Year)
        {
            AgeAndSexSummary = $"{_age} {yearMonthOrDay} old {_sex} patient.";
        }
        private void GenerateDiagnosticsSummaryText()
        {
            if (Diagnostics.Count == 1)
            {
                DiagnosticsSummary =
                      $"The patient has {Diagnostics[0]}.";
            }
            else if (Diagnostics.Count > 1)
            {
                DiagnosticsSummary =
                $"The patient has {Diagnostics[0]} and {Diagnostics[1]}.";
            }
            else
            {
                DiagnosticsSummary =
                    "The patient has no diagnostics.";
            }


        }

        private void GenerateAllergiesSummaryText()
        {
            if (Allergies.Count == 1)
            {
                AllergiesSummary =
                     $"The patient is allergic to {Allergies[0]}.";
            }
            else if (Allergies.Count > 1)
            {
                AllergiesSummary =
                    $"The patient is allergic to {Allergies[0]} and {Allergies[1]}.";
            }
            else
            {
                AllergiesSummary =
                    "The patient has no allergies.";
            }


        }


        private void AddDiagnostics()
        {
            if (MyVisibility == Visibility.Hidden)
            {
                MyVisibility = Visibility.Visible;
                DiagnosticsAddButtonName = "Done";
            }
            else
            {
                MyVisibility = Visibility.Hidden;
                DiagnosticsAddButtonName = "Add";

                Diagnostics =
                    _collectionsManagerService.AddDelimitedValuesToCollection(CommaDelimitedDiagnostics, ',', Diagnostics);

                CommaDelimitedDiagnostics = string.Empty;

            }

            if (Diagnostics.Count <= 2)
            {
                GenerateDiagnosticsSummaryText();
            }

        }

        private void AddAllergies()
        {

            if (MyVisibility == Visibility.Hidden)
            {
                MyVisibility = Visibility.Visible;
                DiagnosticsAddButtonName = "Done";
            }
            else
            {
                MyVisibility = Visibility.Hidden;
                DiagnosticsAddButtonName = "Add";

                Allergies =
                     _collectionsManagerService.AddDelimitedValuesToCollection(CommaDelimitedAllergies, ',', Allergies);

                CommaDelimitedAllergies = string.Empty;

            }

            if (Allergies.Count <= 2)
                GenerateAllergiesSummaryText();
        }

        private void RemoveDiagnostics()
        {

            Diagnostics = _collectionsManagerService
                .RemoveFromCollection(DiagnosticsListBoxSelectedIndex, Diagnostics);

            if (Diagnostics.Count <= 2)
                GenerateDiagnosticsSummaryText();


        }

        private void RemoveAllergies()
        {

            Allergies = _collectionsManagerService
                 .RemoveFromCollection(AllergiesListBoxSelectedIndex, Allergies);

            if (Allergies.Count <= 2)
                GenerateAllergiesSummaryText();


        }



        private void SaveAndClose()
        {
            UpdateModel();//Update working model

            //Compare models using IEqualityComparer Implementation
            if (Equals(Model, DeserializedPatientModel))
            {
                Application.Current.Shutdown();

            }
            else
            {

                var updatePatient = MessageBox.Show("Do you want to update changes made to this patient?",
                    "Attention", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
                if (updatePatient == MessageBoxResult.Yes)
                {
                    try
                    {

                        _patientDataRepository.WriteToJsonFile(Model);

                        Application.Current.Shutdown();

                    }
                    catch (JsonException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }

                }
                else
                {
                    Application.Current.Shutdown();

                }
            }

        }

        public void UpdateModel()
        {
            Model.FullName = FullName;
            Model.BirthDate = BirthDate;
            Model.Sex = Sex;
            Model.PictureName = PictureName;
            Model.Notes = Notes ?? "";
            Model.Diagnostics = Diagnostics;
            Model.Allergies = Allergies;

        }

        #endregion

        public bool Equals(PatientModel workingModel, PatientModel deserializedPatientModel)
        {
            if (workingModel == null && deserializedPatientModel == null)
                return true;
            if (workingModel == null || deserializedPatientModel == null)
                return false;

            if (workingModel.FullName == deserializedPatientModel.FullName
                && workingModel.PictureName == deserializedPatientModel.PictureName
                && workingModel.BirthDate == deserializedPatientModel.BirthDate
                && workingModel.Sex == deserializedPatientModel.Sex
                && workingModel.Notes == deserializedPatientModel.Notes
                && workingModel.Diagnostics.SequenceEqual(deserializedPatientModel.Diagnostics)
                && workingModel.Allergies.SequenceEqual(deserializedPatientModel.Allergies))
                return true;

            return false;


        }

        public int GetHashCode(PatientModel obj)
        {
            throw new NotImplementedException();
        }
    }


}
