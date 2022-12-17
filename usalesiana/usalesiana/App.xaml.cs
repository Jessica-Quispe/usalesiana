using System;
using usalesiana.vistas.Menuprincipal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using usalesiana.vistas.Detalle;
namespace usalesiana
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Principal());
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
