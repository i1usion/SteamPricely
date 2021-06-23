using SteamPricely.Interfaces;
using SteamPricely.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotification;
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

                var notification = new NotificationRequest
                {
                    Title = "Success!",
                    Description = "Thanks for using premium. Enjoy!",
                    ReturningData = "Dummy data",
                    NotificationId = 10001,
                };

                await NotificationCenter.Current.Show(notification);

                Navigation.PushAsync(new MenuPage());
            }
            else
            {
                Error.IsVisible = true;
            }
        }




    }
}