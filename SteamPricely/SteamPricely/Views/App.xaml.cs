using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SteamPricely
{
    public partial class App : Application
    {
        public static Boolean _isPremium { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
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
