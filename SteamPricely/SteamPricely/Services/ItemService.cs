using SQLite;
using SteamPricely.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.ComponentModel;
using System.Net;
using Newtonsoft.Json;
using System.Data;

namespace SteamPricely.Services
{
    public static class ItemService
    {
        static SQLiteAsyncConnection db;
        public static async Task Init()
        {
            if (db != null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "ItemData.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<ItemSearchDb>();
        }

        public static async Task<Boolean> ValidateKey(string key)
        {
            string res;

            using (WebClient client = new WebClient())
            {
                res = client.DownloadString($"https://steamlistfunctionapp.azurewebsites.net/api/PremiumKey?code=NEiwrZxCeiyle8AG6wwf5QbYWVwivx5dmwSyeEaEwdOOy/Eq754UzQ==&checkKey=" + key);
            }

            Boolean isValidated = bool.Parse(res);

            return isValidated;
        }

        public static async Task UpdateTable()
        {
            string json;
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString($"https://steamlistfunctionapp.azurewebsites.net/api/SkinsDB?code=QA5LVde5FifWLQrCdksWeKLksh7YcOC7HCZE2waO/XmhYrLuvdEPHw==");

            }

            var data = JsonConvert.DeserializeObject<List<ItemSearchDb>>(json);
            await db.InsertAllAsync(data);

        }

        public static async Task RefreshTable()
        {
            await Init();
            await db.DeleteAllAsync<ItemSearchDb>();
            await UpdateTable();
        }

        public static Task<List<ItemSearchDb>> GetAllSearchItems()
        {

            return db.Table<ItemSearchDb>().ToListAsync();

        }

        public static async Task<FullItemData> loadPriceData(FullItemData item)
        {
            string json;

            if (App._isPremium == false)
            {
                using (WebClient client = new WebClient())
                {
                    string url = "https://steamlistfunctionapp.azurewebsites.net/api/PricempirePrice?code=fEaafaLhcQaclNik/HYWqHO7O4tDfCxpQGud9lqTFIFsVW75GzotLw==&name=" + item.Name + "&exterior=" + item.Exterior + "&markets=steam,csmoney,buff163&currency=USD";
                    json = client.DownloadString(url);
                }

            }
            else
            {

                using (WebClient client = new WebClient())
                {

                    string url = "https://steamlistfunctionapp.azurewebsites.net/api/PricempirePrice?code=fEaafaLhcQaclNik/HYWqHO7O4tDfCxpQGud9lqTFIFsVW75GzotLw==&name=" + item.Name + "&exterior=" + item.Exterior + "&markets=steam,csmoney,buff163,bitskins,csgotm,csgoexo,swapgg,skinport,dmarket,vmarket,waxpeer&currency=USD";
                    json = client.DownloadString(url);

                }
            }

            DeserialClass data = await Task.Run( () => JsonConvert.DeserializeObject<DeserialClass>(json));

            FullItemData res = new FullItemData();

            if (App._isPremium == false)
            {
                res.steam = data.item.prices.steam_listing_avg90?.price;
                res.csmoney = data.item.prices.csmoney_avg90?.price;
                res.buff163 = data.item.prices.buff163_avg90?.price;

                
            }
            else
            {
                res.steam = data.item.prices.steam_listing_avg90?.price;
                res.csmoney = data.item.prices.csmoney_avg90?.price;
                res.buff163 = data.item.prices.buff163_avg90?.price;
                res.bitskins = data.item.prices.bitskins_avg90?.price;
                res.csgotm = data.item.prices.csgotm_avg90?.price;
                res.csgoexo = data.item.prices.csgoexo_avg90?.price;
                res.swapgg = data.item.prices.swapgg_avg90?.price;
                res.skinport = data.item.prices.skinport_avg90?.price;
                res.dmarket = data.item.prices.dmarket_avg90?.price;
                res.vmarket = data.item.prices.vmarket_avg90?.price;
                res.waxpeer = data.item.prices.waxpeer_avg90?.price;
            }
            return res;
            

        }

        public class DeserialClass
        {
            public Boolean status { get; set; }
            public itemData item { get; set; }
        }

        public class itemData
        {
            public string name { get; set; }
            public itemPrices prices { get; set; }
        }

        public class itemPrices
        {
            public steam_avg90 steam_listing_avg90 { set; get; }
            public buff163_avg90 buff163_avg90 { set; get; }
            public csmoney_avg90 csmoney_avg90 { set; get; }
            public bitskins_avg90 bitskins_avg90 { set; get; }
            public csgotm_avg90 csgotm_avg90 { set; get; }
            public csgoexo_avg90 csgoexo_avg90 { set; get; }
            public swapgg_avg90 swapgg_avg90 { set; get; }
            public skinport_avg90 skinport_avg90 { set; get; }
            public dmarket_avg90 dmarket_avg90 { set; get; }
            public vmarket_avg90 vmarket_avg90 { set; get; }
            public waxpeer_avg90 waxpeer_avg90 { set; get; }

        }

        public class defPrice
        {
            public string price { set; get; }
            
        }

        public class steam_avg90 : defPrice
        {

        }

        public class buff163_avg90 : defPrice
        {

        }

        public class csmoney_avg90 : defPrice
        {

        }

        public class bitskins_avg90 : defPrice
        {

        }

        public class csgotm_avg90 : defPrice
        {

        }

        public class csgoexo_avg90 : defPrice
        {

        }

        public class swapgg_avg90 : defPrice
        {

        }

        public class skinport_avg90 : defPrice
        {

        }

        public class dmarket_avg90 : defPrice
        {

        }

        public class vmarket_avg90 : defPrice
        {

        }

        public class waxpeer_avg90 : defPrice
        {

        }


    }
}
