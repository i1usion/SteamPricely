using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SteamPricely
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }


        private void btnFree_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }
    }
}
