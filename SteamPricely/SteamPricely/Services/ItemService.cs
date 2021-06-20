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

        public static async Task UpdateTable()
        {
            string json;
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString($"https://steamlistfunctionapp.azurewebsites.net/api/HttpTrigger1?code=T9t19XwwSa045AMyQQsBZAHJ/kevErkrakUwM64S/oiDJVm4JLrsuQ==");
                
            }
            
            var data = JsonConvert.DeserializeObject<List<ItemSearchDb>>(json);         
            await db.InsertAllAsync(data);       

        }

        public static Task<List<ItemSearchDb>> GetAllSearchItems()
        {
            
            return db.Table<ItemSearchDb>().ToListAsync();
            
        }

       



    }
}
