using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MVVM_Pattern_Sample_Project.Commands;
using MVVM_Pattern_Sample_Project.Model;
using MVVM_Pattern_Sample_Project.Properties;
using Newtonsoft.Json;

namespace MVVM_Pattern_Sample_Project.ViewModels
{
    public class PatientViewModel : INotifyPropertyChanged
    {
        #region Properties

        private PatientModel _model;
        public ObservableCollection<PatientModel> PatientSummary { get; set; }
        public ObservableCollection<string> Diagnostics { get; set; }

        public ObservableCollection<string> Allergies { get; set; }

        private DelegateCommand _closeAndSaveCommand { get; set; }

        private string _fullName;
        private string _sex;
        private DateTime _birthDate;
        private int _age;
        private string _notes;
        private string pictureName;
        private string _ageAndSexSummary;
        private string _diagnosticsSummary;
        private string _allergiesSummary;


        public PatientModel Model
        {
            get => _model;
            set
            {
                _model = value;
                    OnPropertyChanged(nameof(Model));
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
            }
        }

        public string PictureName
        {
            get => pictureName;

            set
            {
                if (value != null && pictureName != value)
                    pictureName = Resources.ApplicationImagesDirectory + value;
                OnPropertyChanged(nameof(PictureName));

            }
        }

        public string BirthDate
        {
            get => _birthDate.ToShortDateString();

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








        public string Notes
        {
            get => _notes;
            set
            {
                if (_notes != null && _notes != value)
                    _notes = value;

                OnPropertyChanged(nameof(Notes));
            }
        }


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



        public PatientViewModel()
        {
            PatientSummary = new ObservableCollection<PatientModel>();
            Diagnostics = new ObservableCollection<string>();
            Allergies = new ObservableCollection<string>();
            LoadPatient();
            GenerateDiagnosticsSummaryText();
            GenerateAllergiesSummaryText();
            _closeAndSaveCommand = new DelegateCommand(a => CloseAndSave());
        }

        private void CloseAndSave()
        {
          
               
               
            try
            {
                string output = JsonConvert.SerializeObject(PatientSummary);
                output = output.Replace("[{", "{");
                output = output.Replace("}]", "}");
           
                File.WriteAllText(Resources.ApplicationDataFileDirectory,output);

            }
            catch (JsonException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
                
           
        }


        #region Commands

        public DelegateCommand CloseAndSaveChangesCommand => _closeAndSaveCommand;

        #endregion


        #region Methods

        public void LoadPatient()
        {
            using (StreamReader reader = new StreamReader(Resources.ApplicationDataFileDirectory))
            {
                string json = reader.ReadToEnd();
                var patientList = JsonConvert.DeserializeObject<PatientModel>(json);

                PatientSummary.Add(patientList);

                FullName = patientList.FullName;
                PictureName = patientList.PictureName;
                BirthDate = patientList.BirthDate;
                Sex = patientList.Sex;

                
                foreach (var patientDiagnostic in patientList.Diagnostics)
                {
                    Diagnostics.Add(patientDiagnostic);
                }

                foreach (var patientallergy in patientList.Allergies)
                {
                    Allergies.Add(patientallergy);
                }

            }
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

        #endregion
      
    }


}
