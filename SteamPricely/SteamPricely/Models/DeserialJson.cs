using System;
using System.Collections.Generic;
using System.Text;

namespace SteamPricely.Models
{
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
