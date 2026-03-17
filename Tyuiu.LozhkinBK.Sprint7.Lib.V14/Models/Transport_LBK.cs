using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models
{
    public class Transport_LBK
    {
        public string TransportType { get; set; }

        public int RouteNumber { get; set; }

        public DateTime StartDate { get; set; }

        public string StartStop { get; set; }

        public string EndStop { get; set; }

        public int TravelTime { get; set; }

        public string Note { get; set; }
    }
}
