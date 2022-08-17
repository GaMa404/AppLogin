using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppLogin.Model;
using AppLogin.View;

namespace AppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
