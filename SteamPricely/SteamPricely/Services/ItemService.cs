using SQLite;
using SteamPricely.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SteamPricely.Services
{
    public static class ItemService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            { 
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "ItemData.db");
            await db.CreateTableAsync<ItemSearchDb>();
        }

        public static async Task UpdateTable()
        {
            //TODO: Сделать подгрузку с ДБ на Азуре
            await Init();

            
        }
        public static async Task LoadInfo()
        {
            var ItemList = await db.Table<ItemSearchDb>().ToListAsync();
        }


    }
}
