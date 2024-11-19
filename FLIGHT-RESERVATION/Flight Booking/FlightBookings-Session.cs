﻿using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails;
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
    internal class FlightDetails_Session
    {

        private static FlightDetails_Session _instance;

        public static FlightDetails_Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FlightDetails_Session();
                }
                return _instance;
            }
        }

        public string Type { get; private set; }
        public string Email { get; set; }
        public float TotalPrice { get; set; }
        public string PaymentMode { get; set; }
        public string GcashReferenceNumber { get; set; }
        public string DepartureAirplaneNumber { get; set; }
        public string ReturnAirplaneNumber { get; set; }
        public Dictionary<string, string> FlightDetails { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<String, String>> PassengerDetails { get; set; } = new Dictionary<string, Dictionary<String, String>>();

        public Dictionary<string, Boolean> Addons { get; set; } = new Dictionary<string, Boolean>();

        public Dictionary<String, String> CardDetails { get; set; } = new Dictionary<string, string>();


        public void setGuestDetails(Dictionary<String, GuestDetails> guestDetails)
        { 
            PassengerDetails.Clear();
            foreach (var key in guestDetails.Keys)
            {
                PassengerDetails[key] = new Dictionary<string, string>();
            }
            foreach (KeyValuePair<string, GuestDetails> item in guestDetails)
            {
                String FirstName = item.Value.txtFirstName.Text;
                String LastName = item.Value.txtLastName.Text;
                String Age = item.Value.txtAge.Text;
                String Birthdate = item.Value.txtBirthdate.Text;
                var guestInfo = new Dictionary<string, string>
                {
                    { "FirstName", FirstName },
                    { "LastName", LastName },
                    { "Age", Age },
                    { "Birthdate", Birthdate }
                };

                PassengerDetails[item.Key] = guestInfo;
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
            FlightDetails["Class Seat"] = ClassSeat;
            FlightDetails["Number of Adults"] = numAdult;
            FlightDetails["Number of Children"] = numChildren;
            FlightDetails["Number of Infants"] = numInfant;
        }


    }
}
