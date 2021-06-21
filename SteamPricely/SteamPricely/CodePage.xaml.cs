using SteamPricely.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SteamPricely
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodePage : ContentPage
    {
        public CodePage()
        {
            InitializeComponent();
        }

        private async void CheckButton_Clicked(object sender, EventArgs e)
        {
            var key = Key.Text;
            Boolean isCorrect = await ItemService.ValidateKey(key);

            if(isCorrect)
            {
                App._isPremium = true;
                Navigation.PushAsync(new MenuPage());
            }
            else
            {
                Error.IsVisible = true;
            }
        }
    }
}