﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Management;
using System.Reflection;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using static RemziCicek.Class.Entegref;
using RemziCicek.Class;

namespace RemziCicek
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.False;
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("TR-tr");
            RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
            var sonuc = key2.GetValue("ApplicationSetupComplate");
            if (sonuc == null)
            {
                RunAsync().Wait();
            }
            bool acikmi = false;
            Mutex mtex = new Mutex(true, "Program", out acikmi);
            if (acikmi)
            {

                RegistryKey key3 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
                var sonuc2 = key3.GetValue("ApplicationVersion");
                if (sonuc2 == null)
                {
                    string _s4 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
                    key.SetValue("ApplicationVersion", _s4);
                    key.Close();
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmMain());
                Application.Run(new frmLogin());
            }
            else
            {
                MessageBox.Show("Program Çalışıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static async Task RunAsync()
        {
            // Asenkron işlemleri burada gerçekleştirin
            //await Task.Delay(1000); // Örnek bir asenkron işlem

            string Cpuid = "";
            string Motherboardid = "";
            //string fileName = "Abto\\Register_SIP_SDK_ActiveX.bat"; // .bat dosyanızın adı

            //// Proje dizini içindeki .bat dosyanızın tam yolunu oluşturun
            //string pathToBatFile = System.IO.Path.Combine(Application.StartupPath, fileName);


            //Process process = new Process();
            //process.StartInfo.FileName = "cmd.exe"; // Komutları çalıştırmak için komut istemcisini (cmd.exe) kullanıyoruz.
            //process.StartInfo.Arguments = "/c " + pathToBatFile; // /c parametresi, komut istemcisini kapatır (cmd.exe'yi çalıştırdıktan sonra kapatır).
            //process.Start();

            string _s4 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); // versiyon
            string _s5 = System.Reflection.Assembly.GetExecutingAssembly().GetName().CultureInfo.ToString(); // kültür bilgisi
            string _s6 = System.Reflection.Assembly.GetEntryAssembly().GetName().Name.ToString(); // proje adı
            string _s7 = ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false)).Company; // şirket
            string _s8 = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute), false)).Copyright; // Copyright
            ManagementObjectSearcher query = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            ManagementObjectSearcher CPU = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectSearcher MOTHERBOARD = new ManagementObjectSearcher("select * from Win32_BaseBoard");
            foreach (ManagementObject obj in CPU.Get())
            {
                Cpuid = obj["ProcessorID"].ToString();
            }
            foreach (ManagementObject obj in MOTHERBOARD.Get())
            {
                Motherboardid = obj["SerialNumber"].ToString();
            }
            ManagementObjectCollection queryCollection = query.Get();
            string pcModeli = "";
            string pcİsmi = "";
            foreach (var item in queryCollection)
            {
                pcModeli = item["model"].ToString();
                pcİsmi = item["name"].ToString();
            }

            var assembly = typeof(Program).Assembly;
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            var id = attribute.Value;
            RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
            Entegref client = new Entegref();
            string response = await client.UpdateLicensingUser("6200080458", pcİsmi.ToString(), pcModeli.ToString(), _s4, _s6);
            //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseData);
            List<Sonuc> myDeserializedClass = JsonConvert.DeserializeObject<List<Sonuc>>(response);
            var ConnectionLisansingID = myDeserializedClass[0].message;
            string response2 = await client.UpdateLicensing("6200080458", ConnectionLisansingID.ToString(), Cpuid.ToString(), Motherboardid.ToString(), _s6);
            List<Sonuc> myDeserializedClass2 = JsonConvert.DeserializeObject<List<Sonuc>>(response2);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
            var LisansingID2 = myDeserializedClass2[0].message;
            key.SetValue("ApplicationSetupComplate", "True");
            key.GetValue("ApplicationVKN", "6200080458");
            key.SetValue("ApplicationGUID", id);
            key.SetValue("ApplicationVersion", _s4);
            key.SetValue("ApplicationPhoneLisans", true);
            key.SetValue("CPU", Cpuid);
            key.SetValue("motherboardid", Motherboardid);
            key.SetValue("ComputerName", pcİsmi.ToString());
            key.SetValue("ComputerID", pcModeli);
            key.Close();
        }
    }
}
