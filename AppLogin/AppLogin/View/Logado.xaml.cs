using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Logado : ContentPage
    {
        public Logado()
        {
            InitializeComponent();

           NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {   
            bool confirmar = await DisplayAlert("Tem certeza?", "Desconectar sua conta?", "Sim", "Não");

            if (confirmar)
            {
                App.Current.Properties.Remove("usuario_logado");
                App.Current.MainPage = new Login();
            }
        }
    }
}