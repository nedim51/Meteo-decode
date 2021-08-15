using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Декодер_Метео_Файлов;

namespace Meteo_decode.Classes
{
    class VeriablesTemplate
    {
        public static City a = new City {
            value = "111123",
            i = 1,
            j = 2,
            feature = new Feature { value = "4444", i = 2, j = 4 }
        };
}

    public class City {
        public string value { get; set; }
        public int i { get; set; }
        public int j { get; set; }
        public Feature feature { get; set; }
    }

    public class Feature
    {
        public string value { get; set; }
        public int i { get; set; }
        public int j { get; set; }
    }
}
