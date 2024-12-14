﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VolantMusteriDuzel.Class
{
    public static class Volant
    {

        public class Magazalar
        {
            public string DIVVAL { get; set; }
            public string DIVNAME { get; set; }

        }
        public class AllDataBase
        {
            public string DbNAme { get; set; }
        }
        public class Firma
        {
            public string COMPANYDB { get; set; }
            public string COMPANYNAME { get; set; }

        }
        private static string password = "310894";
        public class eDatabase
        {
            public string sqlServerName { get; set; }

            public string databaseName { get; set; }

            public string login { get; set; }

            public string password { get; set; }

            public string integratedSecurity { get; set; }

            public string company { get; set; }

            public string divison { get; set; }

            public string year { get; set; }

            public string pathOfPrints { get; set; }

            public string pathOfArchive { get; set; }

            public string serverPort { get; set; }

            public string serverDbName => sqlServerName + databaseName;

            public string language { get; set; }
        }
        public static string TextSifreCoz(this string text)
        {
            byte[] SifrelenmisByteDizisi = Convert.FromBase64String(text);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[13]
            {
            73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
            100, 101, 118
            });
            byte[] SifresiCozulmusVeri = SifreCoz(SifrelenmisByteDizisi, pdb.GetBytes(32), pdb.GetBytes(16));
            return Encoding.Unicode.GetString(SifresiCozulmusVeri);
        }
        private static byte[] SifreCoz(byte[] SifreliVeri, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(SifreliVeri, 0, SifreliVeri.Length);
            cs.Close();
            return ms.ToArray();
        }

        public static class StartupExtension
        {
            public static string company { get; set; }

            public static string mirCompany { get; set; }

            public static string divison { get; set; }

            public static string companyName { get; set; }

            public static string companyTitle { get; set; }

            public static string divisonName { get; set; }

            public static string divisonUnite { get; set; }

            public static string divShipmentDiv { get; set; }

            public static string divNote { get; set; }

            public static string soAgentId { get; set; }

            public static int? year { get; set; }

            public static int? month { get; set; }

            public static string rdms { get; set; }

            public static string connectionString { get; set; }

            public static string connectionStringMir { get; set; }

            public static string server { get; set; }

            public static string database { get; set; }

            public static string firstDatabase { get; set; }

            public static string firstServer { get; set; }

            public static string useReason { get; set; }

            public static string soCode { get; set; }

            public static string enterKey { get; set; }

            public static bool? admin { get; set; }

            public static bool? mobile { get; set; }

            public static string department { get; set; }

            public static long? terminal { get; set; }

            public static string computerName { get; set; }

            public static string computerTitle { get; set; }

            public static string clientName { get; set; }

            public static string serverPort { get; set; }

            public static DateTime startupTime { get; set; }

            public static string pathOfExe { get; set; }

            public static string pathOfPrints { get; set; }

            public static string pathOfArchive { get; set; }

            public static bool? mainDiv { get; set; }

            public static bool? dbFirst { get; set; }

            public static string lisanceVal { get; set; }
            public static string tabletConnectionString { get; set; }

            public static string tabletConnectionSa { get; set; }

            public static string tabletConnectionPassword { get; set; }

            public static string systemBit
            {
                get
                {
                    try
                    {
                        return (IntPtr.Size == 8) ? "x64" : "x86";
                    }
                    catch
                    {
                        return "x86";
                    }
                }
            }

            public static string AssemblyDirectory
            {
                get
                {
                    string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                    UriBuilder uri = new UriBuilder(codeBase);
                    string path = Uri.UnescapeDataString(uri.Path);
                    return Path.GetDirectoryName(path);
                }
            }
        }
    }
}
