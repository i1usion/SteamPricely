using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamPricely.Models
{
    public class ItemSearchDb
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Exterior { get; set; }
        public string imageUrl { get; set; }
    }

    
}
