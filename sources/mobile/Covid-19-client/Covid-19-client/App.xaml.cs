using Xamarin.Forms;
using Covid19Client.Views.DailyReport;

namespace Covid19Client
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
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
