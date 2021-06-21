using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SteamPricely.Services;
using System.Net.Http;
using SQLite;
using SteamPricely.Models;

namespace SteamPricely
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        static SQLiteAsyncConnection db;
        List<ItemSearchDb> ItemList;
        
        public MenuPage()
        {
            InitializeComponent();
            getSearchInfo();
            
        }

       


            private void SearchBar_TextChanged(object sender, TextChangedEventArgs e){
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                listView.ItemsSource = ItemList;
            }

            else
            {
                listView.ItemsSource = ItemList.Where(x => x.Name.StartsWith(e.NewTextValue));
            }

        }

        public async void getSearchInfo()
        {
            await ItemService.Init();
            ItemList = await ItemService.GetAllSearchItems();

            if(ItemList.Count < 3)
            {
                await ItemService.UpdateTable();
                ItemList = await ItemService.GetAllSearchItems();
            }


            listView.ItemsSource = ItemList;


        }
    

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ItemSearchDb)e.SelectedItem;
            Navigation.PushAsync(new ItemPage(item));

        }

        
    }

  
}