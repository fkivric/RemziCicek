using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntegreFYonAvmTool.Class
{

    public class Entegref
    {
        public class Token
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
        }
        public class EntegrefAPI
        {
            public int statusCode { get; set; }
            public bool success { get; set; }
            public string results { get; set; }
            public string message { get; set; }
            public string internalMessage { get; set; }
            public List<Validation> validations { get; set; }
        }
        public class Validation
        {
            public string Field { get; set; }
            public string Message { get; set; }
        }
        public class Sonuc
        {
            public bool status { get; set; }
            public string message { get; set; }
        }
        public class ReturnModel
        {
            public bool status { get; set; }
            public string message { get; set; }
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        public class ConnectionList
        {
            public string ServerName { get; set; }
            public string Conncetion { get; set; }
        }
        public static Dictionary<string, string> ParseConnectionString(string connectionString)
        {
            Dictionary<string, string> connectionProperties = new Dictionary<string, string>();

            string[] properties = connectionString.Split(';');
            foreach (string property in properties)
            {
                string[] keyValue = property.Split('=');
                if (keyValue.Length == 2)
                {
                    connectionProperties[keyValue[0].Trim()] = keyValue[1].Trim();
                }
            }

            return connectionProperties;
        }
        private static readonly HttpClient client = new HttpClient();
        public async Task<string> SetVersion(string VKN, string Name, string version, string appname)
        {
            string baseUrl = "http://lisans.entegref.com/"; // API URL'nizi buraya ekleyin
            //string baseUrl = "https://localhost:44371/"; // API URL'nizi buraya ekleyin

            string requestUrl = $"{baseUrl}/api/data/Versiyoninsert?VKN={VKN}&Name={Name}&version={version}&AppName={appname}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            else
            {
                Console.WriteLine($"Hata kodu: {response.StatusCode}");
                return null;
            }
        }
        public async Task<string> Versiyon(string VKN, string Name, string appname)
        {
            string baseUrl = "http://lisans.entegref.com/"; // API URL'nizi buraya ekleyin
            //string baseUrl = "http://localhost:24853/"; // API URL'nizi buraya ekleyin

            string requestUrl = $"{baseUrl}/api/data/VersiyonCheck?VKN={VKN}&Name={Name}&AppName={appname}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            else
            {
                Console.WriteLine($"Hata kodu: {response.StatusCode}");
                return null;
            }
        }

        public async Task<string> UpdateLicensingUser(string VKN, string Name, string ID, string version, string appname)
        {
            string baseUrl = "http://lisans.entegref.com/"; // API URL'nizi buraya ekleyin
            //string baseUrl = "https://localhost:44371/"; // API URL'nizi buraya ekleyin

            string requestUrl = $"{baseUrl}/api/data/UpdateLisansingUser?VKN={VKN}&Name={Name}&ID={ID}&version={version}&AppName={appname}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            else
            {
                Console.WriteLine($"Hata kodu: {response.StatusCode}");
                return null;
            }
        }

        public async Task<string> UpdateLicensing(string VKN, string lisansID, string cpuid, string mdid, string appname)
        {
            string baseUrl = "http://lisans.entegref.com/"; // API URL'nizi buraya ekleyin
            //string baseUrl = "https://localhost:44371/"; // API URL'nizi buraya ekleyin

            string requestUrl = $"{baseUrl}/api/data/UpdateLisansing?VKN={VKN}&lisansID={lisansID}&cpuid={cpuid}&mdid={mdid}&AppName={appname}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            else
            {
                Console.WriteLine($"Hata kodu: {response.StatusCode}");
                return null;
            }
        }
    }
}
