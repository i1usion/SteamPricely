using SteamPricely.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamPricely.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SteamPricely
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        FullItemData itemData = new FullItemData();
        public ItemPage(ItemSearchDb ItemInfo)
        {
            
            InitializeComponent();
            dataLoad(ItemInfo);

            BindingContext = this;
        }

        async void dataLoad(ItemSearchDb ItemInfo)
        {
            itemData.Name = ItemInfo.Name;
            itemData.Exterior = ItemInfo.Exterior;
            string BiggerImage = ItemInfo.imageUrl;
            BiggerImage = BiggerImage.Replace("360fx360f", "500fx500f");
            itemData.imageUrl = BiggerImage;

            itemData = await ItemService.loadPriceData(itemData);

            itemData.Name = ItemInfo.Name;
            itemData.Exterior = ItemInfo.Exterior;
            BiggerImage = ItemInfo.imageUrl;
            BiggerImage = BiggerImage.Replace("360fx360f", "500fx500f");
            itemData.imageUrl = BiggerImage;

            ItemImage.Source = itemData.imageUrl;
            ItemName.Text = itemData.Name;
            ItemExterior.Text = itemData.Exterior;


            if (String.IsNullOrEmpty(itemData.steam))
            {
                stackSteam.IsVisible = false;
            }
            else
            {
                stackSteam.IsVisible = true;
                priceSteam.Text = itemData.steam;
            }

            if (String.IsNullOrEmpty(itemData.csmoney))
            {
                stackCsmoney.IsVisible = false;
            }
            else
            {
                stackCsmoney.IsVisible = true;
                priceCsmoney.Text = itemData.csmoney;
            }

            if (String.IsNullOrEmpty(itemData.buff163))
            {
                stackBuff163.IsVisible = false;
            }
            else
            {
                stackBuff163.IsVisible = true;
                priceBuff163.Text = itemData.buff163;
            }

            if (String.IsNullOrEmpty(itemData.bitskins))
            {
                stackBitskins.IsVisible = false;
            }
            else
            {
                stackBitskins.IsVisible = true;
                priceBitskins.Text = itemData.bitskins;
            }

            if (String.IsNullOrEmpty(itemData.csgotm))
            {
                stackCsgotm.IsVisible = false;
            }
            else
            {
                stackCsgotm.IsVisible = true;
                priceCsgotm.Text = itemData.csgotm;
            }

            if (String.IsNullOrEmpty(itemData.csgoexo))
            {
                stackCsgoexo.IsVisible = false;
            }
            else
            {
                stackCsgoexo.IsVisible = true;
                priceCsgoexo.Text = itemData.csgoexo;
            }

            if (String.IsNullOrEmpty(itemData.swapgg))
            {
                stackSwapgg.IsVisible = false;
            }
            else
            {
                stackSwapgg.IsVisible = true;
                priceSwapgg.Text = itemData.swapgg;
            }

            if (String.IsNullOrEmpty(itemData.skinport))
            {
                stackSkinport.IsVisible = false;
            }
            else
            {
                stackSkinport.IsVisible = true;
                priceSkinport.Text = itemData.skinport;
            }

            if (String.IsNullOrEmpty(itemData.dmarket))
            {
                stackDmarket.IsVisible = false;
            }
            else
            {
                stackDmarket.IsVisible = true;
                priceDmarket.Text = itemData.dmarket;
            }

            if (String.IsNullOrEmpty(itemData.vmarket))
            {
                stackVmarket.IsVisible = false;
            }
            else
            {
                stackVmarket.IsVisible = true;
                priceVmarket.Text = itemData.vmarket;
            }

            if (String.IsNullOrEmpty(itemData.waxpeer))
            {
                stackWaxpeer.IsVisible = false;
            }
            else
            {
                stackWaxpeer.IsVisible = true;
                priceWaxpeer.Text = itemData.waxpeer;
            }

        }
    }
}