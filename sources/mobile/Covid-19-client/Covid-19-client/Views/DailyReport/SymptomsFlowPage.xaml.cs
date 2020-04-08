﻿using Covid19Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19Client.Views.DailyReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SymptomsFlowPage : TabbedPage
    {
        public SymptomsFlowPage(SymptomsEnum symptomslist)
        {
            var listOfReportPage = new List<Page>();
            
            if((symptomslist & SymptomsEnum.BreathingIssue)!=0)
            {
                this.Children.Add(new BreathingIssuesReportPage());                
            }
            if ((symptomslist & SymptomsEnum.Fever) != 0)
            {
                this.Children.Add(new FeverSymptomPage());
            }
            if ((symptomslist & SymptomsEnum.MuscularPain) != 0)
            {
                this.Children.Add(new MuscularPainSymptomPage());
            }
            if ((symptomslist & SymptomsEnum.Other) != 0)
            {
                this.Children.Add(new OtherSymptomPage());
            }
            this.Children.Add(new EnvironmentReportPage());
            
            InitializeComponent();
            
        }
    }
}