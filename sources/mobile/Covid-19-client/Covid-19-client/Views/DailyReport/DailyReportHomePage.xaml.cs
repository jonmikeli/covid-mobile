using Covid19Client.ViewModels;
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
    public partial class DailyReportHomePage : ContentPage
    {
        private DailyReportHomeViewModel _viewModel;
        public DailyReportHomePage()
        {
            BindingContext = _viewModel = new DailyReportHomeViewModel();
            InitializeComponent();
        }

        private void Start_Clicked(object sender, EventArgs e)
        {
            var symptomsList = _viewModel._symptoms;
            Navigation.PushModalAsync(new SymptomsFlowPage(symptomsList));
        }
    }
}