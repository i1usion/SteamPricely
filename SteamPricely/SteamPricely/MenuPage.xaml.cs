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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
    }

    public class SearchItem
    {
        public string SkinName { private set; get; }
        public string Exterior { private set; get; }
        public string Img { private set; get; }
        //public string Price { private set; get; } (if needed)

    }
}