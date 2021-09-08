using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MABCI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage(); //pagina por defecto (no nos sirve xD)
            MainPage = new NavigationPage(new Login());//esta es nuestra nueva pagina inicial :D
            //debe ser NavigationPage para poder volver a ella despues :D
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
