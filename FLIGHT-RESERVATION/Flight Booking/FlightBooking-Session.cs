using FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_;
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_AvailableFlights;
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
        public string transactionID { get; set; }
        public string DepartureAirplaneNumber { get; set; }
        public string ReturnAirplaneNumber { get; set; }
        public float BookingSubTotal { get; set; }
        public string TicketDirectory { get; set; }
        public Dictionary<string, string> DepartureAirplaneDetails { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> ReturnAirplaneDetails { get; set; } = new Dictionary<string, string>();


        public Dictionary<string, string> FlightDetails { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<String, String>> PassengerDetails { get; set; } = new Dictionary<string, Dictionary<String, String>>();

        public List<string> PassengerNames = new List<string>();
        public Dictionary<string, Boolean> Addons { get; set; } = new Dictionary<string, Boolean>();

        public Dictionary<String, String> PaymentDetails { get; set; } = new Dictionary<string, string>();
        public List<String> PassengerTypes = new List<string>();


        public void setDepartureAirplaneDetails(FlightsAvailable flight)
        {
            DepartureAirplaneDetails.Clear();
            DepartureAirplaneDetails["Departure Airport Code"] = flight.lblLocation1.Text;
            DepartureAirplaneDetails["Arrival Airport Code"] = flight.lblLocation2.Text;
            DepartureAirplaneDetails["Arrival Date"] = flight.ArrivalDate;
            DepartureAirplaneDetails["Departure Date"] = flight.ArrivalDate;
            DepartureAirplaneDetails["Airplane Number"] = flight.lblAirplaneNumber.Text.Substring(flight.lblAirplaneNumber.Text.IndexOf(":") + 1);
            DepartureAirplaneDetails["Departure Time"] = flight.lblTime1.Text;
            DepartureAirplaneDetails["Arrival Time"] = flight.lblTime2.Text;

            foreach (var item in DepartureAirplaneDetails)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }



        }

        public void setReturnAirplaneDetails(FlightsAvailable flight)
        {
            ReturnAirplaneDetails.Clear();
            ReturnAirplaneDetails["Departure Airport Code"] = flight.lblLocation1.Text;
            ReturnAirplaneDetails["Arrival Airport Code"] = flight.lblLocation2.Text;
            ReturnAirplaneDetails["Arrival Date"] = flight.ArrivalDate;
            ReturnAirplaneDetails["Departure Date"] = flight.ArrivalDate;
            ReturnAirplaneDetails["Airplane Number"] = flight.lblAirplaneNumber.Text.Substring(flight.lblAirplaneNumber.Text.IndexOf(":") + 2);
            ReturnAirplaneDetails["Departure Time"] = flight.lblTime1.Text;
            ReturnAirplaneDetails["Arrival Time"] = flight.lblTime2.Text;

            foreach (var item in ReturnAirplaneDetails)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        public void setAddons(Dictionary<string, Boolean> addons)
        {
            Addons.Clear();
            Addons["Food"] = addons["Food"];
            Addons["Baggage"] = addons["Baggage"];
            Addons["Transport"] = addons["Transport"];
        }

        public void setCardDetails(Dictionary<String, String> Card)
        {
            PaymentDetails.Clear();
            foreach (var item in Card)
            {
                PaymentDetails[item.Key] = item.Value;
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

            setPassengerNames();
            setPassengerTypes();
        }

        public void setPassengerNames()
        {
            PassengerNames.Clear();
            foreach (var item in PassengerDetails)
            {
                var innerDictionary = item.Value;
   
                    PassengerNames.Add($"{innerDictionary["First Name"]} {innerDictionary["Last Name"]}");
                
            }
        }

        public void setPassengerTypes()
        {
            PassengerTypes.Clear();
            foreach (var item in PassengerDetails)
            {
                var innerDictionary = item.Value;
                String PassengerType = innerDictionary["Discounted"] == "Yes" ? innerDictionary["Type"] == "Adult" ? "Adult (Discounted) " : "Adult" : innerDictionary["Type"]; 

                PassengerTypes.Add(PassengerType);

            }
        }

        public void setFlightDetails(Trips trip, String type)
        {
            FlightDetails.Clear();
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
