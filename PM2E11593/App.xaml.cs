using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E11593
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PM2E11593.View.Pantalla1Page();
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
