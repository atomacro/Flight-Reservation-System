using FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_;
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLIGHT_RESERVATION
{
    internal class FlightBooking_Session
    {

        private static FlightBooking_Session _instance;

        public static FlightBooking_Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FlightBooking_Session();
                }
                return _instance;
            }
        }

        public string Type { get; private set; }
        public string Email { get; set; }
        public string DepartureAirplaneNumber { get; set; }
        public string ReturnAirplaneNumber { get; set; }
        public float BookingSubTotal { get; set; }
        public Dictionary<string, string> FlightDetails { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<String, String>> PassengerDetails { get; set; } = new Dictionary<string, Dictionary<String, String>>();

        public Dictionary<string, Boolean> Addons { get; set; } = new Dictionary<string, Boolean>();

        public Dictionary<String, String> PaymentDetails { get; set; } = new Dictionary<string, string>();

        public void setAddons(Dictionary<string, Boolean> addons)
        {
            Addons.Clear();
            Addons["Food"] = addons["Food"];
            Addons["Baggage"] = addons["Baggage"];
            Addons["Transport"] = addons["Transport"];

            foreach(var item in addons)
            {
                Console.WriteLine($"{item.Key} : {item.Value} ");
            }
        }

        public void setCardDetails(Dictionary<String, String> Card)
        {
           foreach(var item in Card)
            {
                PaymentDetails[item.Key] = item.Value;
            }


            foreach (var item in PaymentDetails)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        public void setGuestDetails(Dictionary<String, GuestDetails> guestDetails)
        { 
            PassengerDetails.Clear();
            foreach (var key in guestDetails.Keys)
            {
                PassengerDetails[key] = new Dictionary<string, string>();
            }
            foreach (KeyValuePair<string, GuestDetails> item in guestDetails)
            {
                String FirstName = item.Value.txtFirstName.Text.Trim();
                String LastName = item.Value.txtLastName.Text.Trim();
                String Age = item.Value.txtAge.Text.Trim();
                String Birthdate = item.Value.txtBirthdate.Text.Trim();
                String Discounted = item.Value.chkDiscounted.Checked ? "Yes" : "No";
                String Type = item.Value.type;
                var guestInfo = new Dictionary<string, string>
                {
                    { "Type", Type },
                    { "First Name", FirstName },
                    { "Last Name", LastName },
                    { "Age", Age },
                    { "Birthdate", Birthdate },
                    { "Discounted", Discounted }
                };

                PassengerDetails[item.Key] = guestInfo;
            }

            foreach (var outerEntry in PassengerDetails)
            {
                string outerKey = outerEntry.Key; // Key of the outer dictionary
                var innerDictionary = outerEntry.Value; // Value of the outer dictionary (an inner dictionary)

                Console.WriteLine($"Passenger: {outerKey}");

                foreach (var innerEntry in innerDictionary)
                {
                    string innerKey = innerEntry.Key; // Key of the inner dictionary
                    string innerValue = innerEntry.Value; // Value of the inner dictionary

                    Console.WriteLine($"  {innerKey}: {innerValue}");
                }
            }
        }


            public void setFlightDetails(Trips trip, String type)
        {
            if (FlightDetails != null)
            {
                FlightDetails.Clear();
            }
            Type = type;
            string DepartureLocation = trip.cboDepartureLocationControl.Text;
            string ArrivalLocation = trip.cboArrivalLocationControl.Text;
            string DepartureAirport = trip.lblDepartureAirportNameControl.Text;
            string ArrivalAirport = trip.lblArrivalAirportNameControl.Text;
            string DepartureDate = trip.cboDepartureDateControl.Text;
            string ClassSeat = trip.cboClassSeatControl.Text;
            string numAdult = trip.numAdultControl.Value.ToString();
            string numChildren = trip.numChildrenControl.Value.ToString();
            string numInfant = trip.numInfantsControl.Value.ToString();

            FlightDetails["Departure Location"] = DepartureLocation;
            FlightDetails["Arrival Location"] = ArrivalLocation;
            FlightDetails["Departure Airport Location"] = DepartureAirport;
            FlightDetails["Arrival Airport Location"] = ArrivalAirport;


            FlightDetails["Departure Date"] = DepartureDate;
            if (trip.cboReturnDateControl != null)
            {
                string ReturnDate = trip.cboReturnDateControl.Text;
                FlightDetails["Return Date"] = ReturnDate;
            }
            FlightDetails["Seat Class"] = ClassSeat;
            FlightDetails["Number of Adults"] = numAdult;
            FlightDetails["Number of Children"] = numChildren;
            FlightDetails["Number of Infants"] = numInfant;

            foreach (var item in FlightDetails)
            {
                Console.WriteLine($"{item.Key} : {item.Value} ");
            }

            Console.WriteLine(Type);
        }

    }
}
