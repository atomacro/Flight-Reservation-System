using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLIGHT_RESERVATION
{
    internal class FlightDetails_Session
    {
        public String Type;
        public String Email;
        public float TotalPrice;
        public String PaymentMode;
        public String GcashReferenceNumber;
        public Dictionary<string, string> FlightDetails { get; set; }
        public Dictionary<string, string> ChosenFlight { get; set; }

        public Dictionary<string, List<string>> PassengerDetails { get; set; }

        public Dictionary<string, Boolean> Addons { get; set; } 

        public Dictionary<String, String> CardDetails { get; set; }








    }
}
