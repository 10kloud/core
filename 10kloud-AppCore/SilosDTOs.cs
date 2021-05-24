using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore
{
    public class SilosAPI
    {
        public Silos[] SiloV { get; set; }
    }

    public class Silos
    {
        public string time { get; set; }
        public string sensor_id { get; set; }
        public float pressureInternal { get; set; }
        public int level { get; set; }
        public int tempExternal { get; set; }
        public float humidityExternal { get; set; }
        public string zone { get; set; }
    }


}
