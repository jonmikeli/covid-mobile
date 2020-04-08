using Covid19Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Client.ViewModels
{
    public class DailyReportHomeViewModel : BaseViewModel
    {
        #region Properties
        public SymptomsEnum _symptoms = SymptomsEnum.None;
        
        public bool HaveBreathingIssue
        {
            get { return (_symptoms & SymptomsEnum.BreathingIssue) == SymptomsEnum.BreathingIssue; }
            set
            {
                _symptoms = value == true ? _symptoms | SymptomsEnum.BreathingIssue : _symptoms & ~SymptomsEnum.BreathingIssue;
                OnPropertyChanged("HaveBreathingIssue");
            }
        }        
        public bool HaveFever
        {
            get { return (_symptoms & SymptomsEnum.Fever) == SymptomsEnum.Fever; }
            set
            {
                _symptoms = value == true ? _symptoms | SymptomsEnum.Fever : _symptoms & ~SymptomsEnum.Fever;
                OnPropertyChanged("HaveFever");
            }
        }
        
        public bool HaveMuscularPain
        {
            get { return (_symptoms & SymptomsEnum.MuscularPain) == SymptomsEnum.MuscularPain; }
            set
            {
                _symptoms = value == true ? _symptoms | SymptomsEnum.MuscularPain : _symptoms & ~SymptomsEnum.MuscularPain;
                OnPropertyChanged("HaveMuscularPain");
            }
        }        
        public bool HaveOthers
        {
            get { return (_symptoms & SymptomsEnum.Other) == SymptomsEnum.Other; }
            set
            {
                _symptoms = value == true ? _symptoms | SymptomsEnum.Other : _symptoms & ~SymptomsEnum.Other;
                OnPropertyChanged("HaveOthers");
            }
        }
        #endregion
        public DailyReportHomeViewModel()
        {

        }
    }
}
