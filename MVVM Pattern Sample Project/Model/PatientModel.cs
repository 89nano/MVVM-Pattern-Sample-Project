using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM_Pattern_Sample_Project.Properties;

namespace MVVM_Pattern_Sample_Project.Model
{

    public class PatientModel : INotifyPropertyChanged
    {

        private string fullName;
        private string sex;
        private DateTime birthDate;
        private int age;
        private string notes;
        private string pictureName;
        private string ageAndSexSummary;
        private string diagnosticsSummary;
        private string allergiesSummary;


        public string FullName
        {
            get => fullName;

            set
            {
                if (value != null && fullName != value)
                    fullName = value;

                OnPropertyChanged("FullName");
            }
        }

        public string PictureName
        {
            get { return pictureName; }

            set
            {
                if (value != null && pictureName != value)
                    pictureName = Resources.ApplicationImagesDirectory + value;
            }
        }

        public string BirthDate
        {
            get => birthDate.ToShortDateString();

            set
            {

                if (DateTime.TryParse(value, out birthDate))
                {
                    birthDate = DateTime.Parse(value);
                    CalculateAge(birthDate);
                }

                OnPropertyChanged("BirthDate");

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
                age = (int)daysToYears;
            }
            else if (daysToMonths >= 1)
            {
                age = (int)(dateDifference.TotalDays / 30.416);
                yearMonthOrDay = YearMonthOrDay.Month;
            }

            else
            {

                age = (int)dateDifference.TotalDays;
                yearMonthOrDay = YearMonthOrDay.Day;
            }


            if (!string.IsNullOrEmpty(sex) && age != 0)
                GenerateAgeAndSexText(yearMonthOrDay);
        }

        public string Sex
        {
            get => sex;
            set
            {
                if (sex != value)
                    sex = value;

                OnPropertyChanged("Sex");

                if (!string.IsNullOrEmpty(sex) && age != 0)
                    GenerateAgeAndSexText();

            }
        }



        private void GenerateAgeAndSexText(YearMonthOrDay yearMonthOrDay = YearMonthOrDay.Year)
        {
            AgeAndSexSummary = $"{age} {yearMonthOrDay} old {sex} patient.";
        }

        public string Notes
        {
            get => notes;
            set
            {
                if (notes != null && notes != value)
                    notes = value;

                OnPropertyChanged("Notes");
            }
        }


        public string AgeAndSexSummary
        {
            get => ageAndSexSummary;
            set
            {
                if (!string.Equals(ageAndSexSummary, value, StringComparison.Ordinal))
                    ageAndSexSummary = value;
                OnPropertyChanged("AgeAndSexSummary");
            }

        }



        public ObservableCollection<string> Diagnostics { get; set; }
        public ObservableCollection<string> Allergies { get; set; }


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
        
    }



}
