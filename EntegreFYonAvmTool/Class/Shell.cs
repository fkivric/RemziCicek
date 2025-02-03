using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntegreFYonAvmTool.Class
{
    public class Shell
    {
        public class CustomerSalesTransaction
        {
            public List<PROCESSRESULT> PROCESSRESULTS { get; set; }
            public int COUNTOFSALESTRANSACTIONLIST { get; set; }
            public List<LISTOFTRANSACTION> LISTOFTRANSACTIONS { get; set;}
        }


        public class PROCESSRESULT
        {
            public Boolean Success { get; set; }
            public string Message { get; set; }
            public string Result { get; set; }
        }
        public class LISTOFTRANSACTION
        {
            public string Sales_Type { get; set; }
            public string Customer_Code { get; set; }
            public string Customer_Name { get; set; }
            public string Department_Code { get; set; }
            public string Department_Name { get; set; }
            public string Card_No { get; set; }
            public string Plate_Cd { get; set; }
            public string Viu_Type { get; set; }
            public DateTime Transaction_Date { get; set; }
            public string Retail_Outlet_Code { get; set; }
            public string Retail_Outlet_Name { get; set; }
            public string Rtl_Otlt_Province { get; set; }
            public string Fuel_Name { get; set; }
            public string Group_Code { get; set; }
            public decimal Vehicle_Km { get; set; }
            public decimal Unit_Price { get; set; }
            public decimal Volume { get; set; }
            public decimal Sales_Total_Amount { get; set; }
            public string Invoice_No { get; set; }
            public string Customer_Reference { get; set; }
            public decimal Shell_Reference { get; set; }
        }
    }
}
