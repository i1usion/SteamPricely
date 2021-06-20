using SteamPricely.Models;
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
        public ItemPage(ItemSearchDb ItemInfo)
        {
            InitializeComponent();
            ItemName.Text = ItemInfo.Name;
            ItemExterior.Text = ItemInfo.Exterior;
            ItemImage.Source = ItemInfo.imageUrl;


        }
    }
}