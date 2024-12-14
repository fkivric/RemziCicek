using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static VolantMusteriDuzel.Class.Volant;

namespace RemziCicek.Class
{
    [Serializable]
    public class eDefThemes : ICloneable
    {
        public string DTHENAME { get; set; }

        public string THEVAL { get; set; }

        public string THENOTES { get; set; }

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0L;
                return formatter.Deserialize(stream);
            }
        }
    }
}
