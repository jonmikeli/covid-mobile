﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19Client.Views.DailyReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MuscularPainSymptomPage : ContentPage
    {
        public MuscularPainSymptomPage()
        {
            this.Title = "Muscular Pain";
            InitializeComponent();
        }
    }
}