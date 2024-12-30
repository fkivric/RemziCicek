using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RemziCicek.Class
{
    public class Siniflar
    {
        public class Magazalar
        {
            public string DIVVAL { get; set; }
            public string DIVNAME { get; set; }
        }
        public class Sayim
        {
            public int DEEDID { get; set; }
            public string DPDEEDNAME { get; set; }
            public string DSTORNAME { get; set; }
            public DateTime DEEDDATE { get; set; }
            public string PROBHNOTES { get; set; }
            public double PROBHQUAN { get; set; }
        }
        public class Personel
        {
            public int sira { get; set; }
            public string DIVVAL { get; set; }
            public int SMENID { get; set; }
            public string SMENVAL { get; set; }
            public string SMENNAME { get; set; }
            public string AMOUNT { get; set; }
        }
    }
}
