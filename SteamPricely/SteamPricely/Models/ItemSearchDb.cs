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
        public string Name { set; get; }
        public string Exterior { set; get; }
        public string Img { set; get; }
    }
}
