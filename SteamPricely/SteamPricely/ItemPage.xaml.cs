using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SteamPricely
{
    class ItemData
    {
        public string Name { set; get; }
        public string Exterior { set; get; }
        public string Img { set; get; }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public ItemPage(SearchItem ItemInfo)
        {
            InitializeComponent();
            var FullItemName = ItemInfo.Exterior;
            ItemName.Text = ItemInfo.Name;
            ItemExterior.Text = ItemInfo.Exterior;
            ItemImage.Source = ItemInfo.Img;


        }
    }
}