using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Covid19Client.Services;
using Covid19Client.Views;
using Covid19Client.Views.DailyReport;

namespace Covid19Client
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new DailyReportHomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
