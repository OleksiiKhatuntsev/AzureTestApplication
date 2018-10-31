using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AzureTestApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppCenter.Start("uwp=cafa9c80-83f0-44ac-8001-be2ed9ca38e9;" +
                  "android=468e2eee-eb59-493f-b575-fa2987b9e428;" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics));
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
