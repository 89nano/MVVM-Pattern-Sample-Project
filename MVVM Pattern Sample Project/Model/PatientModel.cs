﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
                    pictureName = value;
            }
        }

        public string BirthDate
        {
            get => birthDate.ToShortDateString();

            set
            {
                if (DateTime.TryParse(value, out birthDate) && birthDate != DateTime.Parse(value))
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
            age = int.Parse((today - birthDate).ToString());
            
        }

        public string Sex
        {
            get => sex;
            set
            {
                if (sex != null && sex != value)
                    sex = value;

                OnPropertyChanged("Sex");

                if (!string.IsNullOrEmpty(sex) && age > 0)
                    GenerateAgeAndSexText();
                
            }
        }

        private void GenerateAgeAndSexText()
        {
            AgeAndSexSummary = $"{age} year old {sex} patient.";
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
    }


}
