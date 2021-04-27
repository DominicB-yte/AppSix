using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;

namespace AppSix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRing_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Call Button Clicked");
            DisplayAlert("", "Calling...", "OK");
        }

        private void btnCrash_Clicked(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }
    }
}
