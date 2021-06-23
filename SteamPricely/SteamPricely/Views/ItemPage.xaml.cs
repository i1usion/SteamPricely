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
            DataLoad(ItemInfo);

            BindingContext = this;
        }

        async void DataLoad(ItemSearchDb ItemInfo)
        {
            itemData.Name = ItemInfo.Name;
            itemData.Exterior = ItemInfo.Exterior;
            string BiggerImage = ItemInfo.imageUrl;
            BiggerImage = BiggerImage.Replace("360fx360f", "500fx500f");
            itemData.imageUrl = BiggerImage;

            itemData = await ItemService.LoadPriceData(itemData);

            ItemImage.Source = BiggerImage;
            ItemName.Text = ItemInfo.Name;
            ItemExterior.Text = ItemInfo.Exterior;


            if (String.IsNullOrEmpty(itemData.steam))
            {
                stackSteam.IsVisible = false;
            }
            else
            {
                stackSteam.IsVisible = true;
                float convar = int.Parse(itemData.steam);
                convar = convar / 100;
                priceSteam.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.csmoney))
            {
                stackCsmoney.IsVisible = false;
            }
            else
            {
                stackCsmoney.IsVisible = true;
                float convar = int.Parse(itemData.csmoney);
                convar = convar / 100;
                priceCsmoney.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.buff163))
            {
                stackBuff163.IsVisible = false;
            }
            else
            {
                stackBuff163.IsVisible = true;
                float convar = int.Parse(itemData.buff163);
                convar = convar / 100;
                priceBuff163.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.bitskins))
            {
                stackBitskins.IsVisible = false;
            }
            else
            {
                stackBitskins.IsVisible = true;
                float convar = int.Parse(itemData.bitskins);
                convar = convar / 100;
                priceBitskins.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.csgotm))
            {
                stackCsgotm.IsVisible = false;
            }
            else
            {
                stackCsgotm.IsVisible = true;
                float convar = int.Parse(itemData.csgotm);
                convar = convar / 100;
                priceCsgotm.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.csgoexo))
            {
                stackCsgoexo.IsVisible = false;
            }
            else
            {
                stackCsgoexo.IsVisible = true;
                float convar = int.Parse(itemData.csgoexo);
                convar = convar / 100;
                priceCsgoexo.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.swapgg))
            {
                stackSwapgg.IsVisible = false;
            }
            else
            {
                stackSwapgg.IsVisible = true;
                float convar = int.Parse(itemData.swapgg);
                convar = convar / 100;
                priceSwapgg.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.skinport))
            {
                stackSkinport.IsVisible = false;
            }
            else
            {
                stackSkinport.IsVisible = true;
                float convar = int.Parse(itemData.skinport);
                convar = convar / 100;
                priceSkinport.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.dmarket))
            {
                stackDmarket.IsVisible = false;
            }
            else
            {
                stackDmarket.IsVisible = true;
                float convar = int.Parse(itemData.dmarket);
                convar = convar / 100;
                priceDmarket.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.vmarket))
            {
                stackVmarket.IsVisible = false;
            }
            else
            {
                stackVmarket.IsVisible = true;
                float convar = int.Parse(itemData.vmarket);
                convar = convar / 100;
                priceVmarket.Text = convar.ToString() + "$";
            }

            if (String.IsNullOrEmpty(itemData.waxpeer))
            {
                stackWaxpeer.IsVisible = false;
            }
            else
            {
                stackWaxpeer.IsVisible = true;
                float convar = int.Parse(itemData.waxpeer);
                convar = convar / 100;
                priceWaxpeer.Text = convar.ToString() + "$";
            }

        }
    }
}