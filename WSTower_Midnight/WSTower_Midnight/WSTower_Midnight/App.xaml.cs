using System;
using WSTower_Midnight.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
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
