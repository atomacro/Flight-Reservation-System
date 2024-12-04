using iText.Html2pdf;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    internal class GeneratePDF
    {

            static void Main(string[] args)
            {
                // Path to save the generated PDF
                string pdfFilePath = "../../test/output.pdf";

                // Create the necessary directory if it doesn't exist
                string directory = Path.GetDirectoryName(pdfFilePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string type = "Round Trip";
                string borderSize = type == "Round Trip" ? "6in" : "3.3in";


                //height 6in - round trip
                //one way 3.3in

                string ReturnString = @"            <br />
            <br />
            <p
              style=""
                color: #763aee;
                font-size: 20px;
                font-family: 'Kantumruy Pro Bold';
              ""
            >
              {ReturnDeparture}-{ReturnArrival}
            </p>
            <p style=""font-size: 17px; font-family: 'Kantumruy Pro Regular'"">
              {DepartureDate} - {ArrivalDate}
            </p>
            <br />
            <div
              style=""
                display: flex;
                font-family: 'kantumruy pro regular';
                font-size: 15px;
              ""
            >
              <div
                style=""
                  display: flex;
                  flex-direction: column;
                  color: darkgray;
                  text-align: center;
                ""
              >
                <p>{ReturnDateOnly}</p>
                <p>{ReturnTimeOnly}</p>
              </div>
              <div
                style=""
                  position: absolute;
                  top: 9.5in;
                  left: 270px;
                  height: 75px;
                  width: 1px;
                  background-color: darkgray;
                ""
              ></div>
              <div style=""margin-left: 100px"">
                <p style=""margin-bottom: 5px"">{ReturnAirplaneNumber}</p>
                <p style=""font-family: 'Kantumruy Pro Medium'; color: darkgray"">
                  DEPARTURE
                </p>
                <p style=""font-family: 'Kantumruy Pro SemiBold'"">
                  {ReturnLocation}
                </p>
                <p
                  style=""font-family: 'Kantumruy Pro Regular'; color: darkgray""
                >
                  {ReturnAirportLocation}
                </p>
              </div>
            </div>";


                string baseString = $@"<!DOCTYPE html>
<html>
  <body>
    <style>
      * {{
        margin: 0;
        padding: 0;
        box-sizing: border-box;
      }}

      @font-face {{
        font-family: ""Kantumruy Pro Bold"";
        src: url(../../html/KantumruyPro-Bold.ttf) format(""truetype"");
      }}
      @font-face {{
        font-family: ""Kantumruy Pro Regular"";
        src: url(../../html/KantumruyPro-Regular.ttf) format(""truetype"");
      }}
      @font-face {{
        font-family: ""Kantumruy Pro SemiBold"";
        src: url(../../html/KantumruyPro-SemiBold.ttf) format(""truetype"");
      }}
      @font-face {{
        font-family: ""Kantumruy Pro Medium"";
        src: url(../../html/KantumruyPro-Medium.ttf) format(""truetype"");
      }}
      @page {{
        margin: 0;
        height: 11in;
        width: 8.5in;
      }}
      .logo {{
        height: 4cm;
      }}
      body {{
        height: 11in;
        width: 8.5in;
      }}
      .header {{
        width: 8.5in;
        height: 1.5cm;
        background-color: #5e17eb;
        display: flex;
        justify-content: center;
        align-items: center;
        color: white;
        font-family: ""Kantumruy Pro Bold"";
      }}
      div.main {{
        width: 8.5in;
        display: flex;
        align-items: center;
        flex-direction: column;
      }}
      div.main section {{
        margin-top: 30px;
        width: 80%;
      }}
      .ThankYou {{
        font-size: 14px;
        font-family: ""Kantumruy Pro Regular"";
        margin-block: 0.5cm 0.75cm;
      }}
      .FlightDetails {{
        width: 100%;
        margin: 0 auto;
        margin: 0 2px 0 0;
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        grid-template-rows: repeat(2, 30px);
      }}
      .FlightDetails p {{
        font-family: ""Kantumruy Pro SemiBold"";
        font-size: 14px;
      }}
      .FlightDetails p.content {{
        font-size: 20px;
      }}
      hr {{
        color: darkgray;
        margin-top: 20px;
        margin-bottom: 10px;
      }}
      div.main section:nth-child(2) h1 {{
        font-size: 20px;
        font-family: ""Kantumruy Pro SemiBold"";
        font-weight: 200;
      }}
    </style>

    <div class=""logo"" style=""height: 1.3in; display: flex; justify-content: center; align-items: center"">
      <img
        src=""../../html/BANNER.png""
      />
    </div>

    <div class=""header"">
      <p>E-TICKET RECEIPT AND ITINERARY</p>
    </div>

    <div class=""main"">
      <section class=""First"" style=""width: 7.2in"">
        <div style=""display: flex; align-items: center"">
          <img src=""../../html/check_circle.png"" />
          <span style=""font-family: 'Kantumruy Pro Bold'; color: #05cf1a""
            >Confirmed</span
          >
        </div>
        <br />
        <p class=""ThankYou"">
          Thank you for choosing Airplane Ticket System. Your transaction was
          successful.
        </p>
        <br />
        <div class=""FlightDetails"">
          <p>BOOKING DATE</p>
          <p>BOOKING REFERENCE NO.</p>
          <p>SEAT CLASS</p>
          <p class=""content"">{bookingDate}</p>
          <p class=""content"">{referenceNo}</p>
          <p class=""content"">{seatClass}</p>
        </div>
        <hr />
      </section>
      <section>
        <h1>Passenger Name: {PassengerName}</h1>
        <h1 style=""margin-bottom: 10px"">Booking Details</h1>
        <section class=""BookingDetails"">
          <div class=""maindiv"" style=""width: 7.2in; padding: 15px 30px"">
            <img
              src=""../../html/border.png""
              style=""
                position: absolute;
                z-index: -1;
                width: 7.4in;
                height: {borderSize};
                top: 5.2in;
                left: 0.5in;
              ""
            />
            <!-- For Departure -->
            <p
              style=""
                color: #763aee;
                font-size: 20px;
                font-family: 'Kantumruy Pro Bold';
              ""
            >
              {Departure}-{Arrival}
            </p>
            <p style=""font-size: 17px; font-family: 'Kantumruy Pro Regular'"">
              {DepartureDate} - {ArrivalDate}
            </p>
            <br />
            <div
              style=""
                display: flex;
                font-family: 'kantumruy pro regular';
                font-size: 15px;
              ""
            >
              <div
                style=""
                  display: flex;
                  flex-direction: column;
                  color: darkgray;
                  text-align: center;
                ""
              >
                <p>{DepartureDateOnly}</p>
                <p>{DepartureTimeOnly}</p>
                <p style=""margin-top: 30px; margin-bottom: 30px"">
                  {TimeDifference}
                </p>
                <p>{ArrivalDateOnly}</p>
                <p>{ArrivalTimeOnly}</p>
              </div>

              <div style=""margin-left: 75px"">
                <p style=""margin-bottom: 5px"">{AirplaneNumber}</p>
                <p style=""font-family: 'Kantumruy Pro Medium'; color: darkgray"">
                  DEPARTURE
                </p>
                <p style=""font-family: 'Kantumruy Pro SemiBold'"">
                  {DepartureLocation}
                </p>
                <p
                  style=""font-family: 'Kantumruy Pro Regular'; color: darkgray""
                >
                  {DepartureAirportLocation}
                </p>
                <br />
                <p style=""font-family: 'Kantumruy Pro Medium'; color: darkgray"">
                  Arrival
                </p>
                <p style=""font-family: 'Kantumruy Pro SemiBold'"">
                  {ArrivalLocation}
                </p>
                <p
                  style=""font-family: 'Kantumruy Pro Regular'; color: darkgray""
                >
                  {ArrivalAirportLocation}
                </p>
              </div>
            </div>

            <!-- For Return -->

";

                string htmlEnd = @"         
            </div>
        </section>
      </section>
    </div>
  </body>
</html>";


                string htmlContent = type == "Round Trip" ? baseString + ReturnString + htmlEnd : baseString + htmlEnd;

                // Convert HTML to PDF
                using (FileStream pdfStream = new FileStream(pdfFilePath, FileMode.Create))
                {
                    var properties = new ConverterProperties();
                    HtmlConverter.ConvertToPdf(htmlContent, pdfStream, properties);
                }

                Console.WriteLine("PDF created successfully at: " + pdfFilePath);
            }
        }

        class PopulateTicket
        {
            public string BookingDate { get; set; }
            public string ReferenceNo { get; set; }
            public string SeatClass { get; set; }
            public string PassengerName { get; set; }
            public string Departure { get; set; }
            public string Arrival { get; set; }
            public string DepartureDate { get; set; }
            public string ArrivalDate { get; set; }
            public string DepartureDateOnly { get; set; }
            public string DepartureTimeOnly { get; set; }
            public string TimeDifference { get; set; }
            public string ArrivalDateOnly { get; set; }
            public string ArrivalTimeOnly { get; set; }
            public string AirplaneNumber { get; set; }
            public string DepartureLocation { get; set; }
            public string DepartureAirportLocation { get; set; }
            public string ArrivalLocation { get; set; }
            public string ArrivalAirportLocation { get; set; }
            public string ReturnDeparture { get; set; }
            public string ReturnArrival { get; set; }
            public string ReturnDateOnly { get; set; }
            public string ReturnTimeOnly { get; set; }
            public string ReturnAirplaneNumber { get; set; }
            public string ReturnLocation { get; set; }
            public string ReturnAirportLocation { get; set; }
            private FlightBooking_Session ses;

            public PopulateTicket()
            {
                ses = FlightBooking_Session.Instance;

                BookingDate = DateTime.Now.ToString("dd/mm/yyyy");

                //ReferenceNo.
                //DepartureDate
                //ArrivalDate
                //TimeDifference
                //Departure
                //Arrival
                SeatClass = ses.FlightDetails["Seat Class"];
                //PassengerName = iisip pa
                ReturnDeparture = Arrival;
                ReturnArrival = Departure;




            }
        }
    
}

