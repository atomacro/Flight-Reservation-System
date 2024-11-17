using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    internal class FlightDetails_Session
    {
        public String Type;
        public String Email;
        public float TotalPrice;
        public String PaymentMode;
        public String GcashReferenceNumber;
        public Dictionary<string, string> FlightDetails { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> ChosenFlight { get; set; } = new Dictionary<string, string>();

        public Dictionary<string, List<string>> PassengerDetails { get; set; } = new Dictionary<string, List<string>>();

        public Dictionary<string, Boolean> Addons { get; set; } = new Dictionary<string, Boolean>();

        public Dictionary<String, String> CardDetails { get; set; } = new Dictionary<string, string>();

        public void setFlightDetails(Trips trip, String type)
        {
            if(FlightDetails != null)
            {
               FlightDetails.Clear();
            }


            Type = type;
            string DepartureLocation = trip.cboDepartureLocationControl.Text;
            string ArrivalLocation = trip.cboArrivalLocationControl.Text;
            string DepartureDate = trip.cboDepartureDateControl.Text;
            string ClassSeat = trip.cboClassSeatControl.Text;
            string numAdult = trip.numAdultControl.Value.ToString();
            string numChildren = trip.numChildrenControl.Value.ToString();
            string numInfant = trip.numInfantsControl.Value.ToString();
            FlightDetails["Departure Location"] = DepartureLocation;
            FlightDetails["Arrival Location"] = ArrivalLocation;
            FlightDetails["Departure Date"] = DepartureDate;
            if (trip.cboReturnDateControl != null)
            {
                string ReturnDate = trip.cboReturnDateControl.Text;
                FlightDetails["Return Date"] = ReturnDate;
            }
            FlightDetails["Class Seat"] = ClassSeat;
            FlightDetails["Number of Adults"] = numAdult;
            FlightDetails["Number of Children"] = numChildren;
            FlightDetails["Number of Infants"] = numInfant;
        }




    }
}
