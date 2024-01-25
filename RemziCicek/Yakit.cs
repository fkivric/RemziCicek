using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemziCicek
{
    public class Yakit
    {
        public string Sales_Type { get; set; }
        public string Plate_Cd { get; set; }
        public DateTime Transaction_Date { get; set; }
        public string Retail_Outlet_Name { get; set; }
        public string Rtl_Otlt_Province { get; set; }
        public string Fuel_Name { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Volume { get; set; }
        public decimal Sales_Total_Amount { get; set; }
        public string Invoice_No { get; set; }
        public string durum { get; set; }

    }

    public class Root2
    {
        public List<Yakit> Alımlar { get; set; }
    }
}
