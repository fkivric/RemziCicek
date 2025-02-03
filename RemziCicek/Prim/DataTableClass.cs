using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemziCicek
{
    public class DataTableClass
    {
        public class Personel
        {
            public int sira { get; set; }
            public string DIVVAL { get; set; }
            public int SMENID { get; set; }
            public string SMENVAL { get; set; }
            public string SMENNAME{ get; set; }
            public string RATE { get; set; }
            public string AMOUNT{ get; set; }
        }
    }    
}
