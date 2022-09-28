using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using System.Threading;
using System.Globalization;

using AppLogin.Model;

namespace AppLogin
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
            {
                MainPage = new NavigationPage(new View.Logado());
            }
            else
            {
                MainPage = new View.Login();
            }
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
