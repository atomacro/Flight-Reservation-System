using iText.Html2pdf;
using iText.Html2pdf.Resolver.Font;
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
        public async Task PDFGenerate()
        {
            var ses = FlightBooking_Session.Instance;

            // Path to save the generated PDF
            string pdfFilePath = $"../../Flight Booking/Tickets/{ses.transactionID}.pdf";
            ses.TicketDirectory = pdfFilePath;

            // Create the necessary directory if it doesn't exist
            string directory = Path.GetDirectoryName(pdfFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string type = ses.Type;
            string borderSize = type == "Round Trip" ? "6in" : "4.3in";
            string Return = type == "Round Trip" ? "block" : "none";
            List<string> PassengerNames = ses.PassengerNames;
            string logoPath = ConvertImageToBase64("../../Flight Booking/TicketDependencies/BANNER.png");
            string checkCirclePath = ConvertImageToBase64("../../Flight Booking/TicketDependencies/check_circle.png");
            string borderPath = ConvertImageToBase64("../../Flight Booking/TicketDependencies/border.png");




            //height 6in - round trip
            //one way 3.3in
            StringBuilder htmlContent = new StringBuilder();

            String TempDepartureDate = $"{ses.DepartureAirplaneDetails["Departure Date"]} {ses.DepartureAirplaneDetails["Departure Time"]} ";
            String TempArrivalDate = $"{ses.DepartureAirplaneDetails["Arrival Date"]} {ses.DepartureAirplaneDetails["Arrival Time"]}";

            String TimeDifference = $"{DateTime.Parse(TempArrivalDate) - DateTime.Parse(TempDepartureDate)}";



            var departureDetails = ses.DepartureAirplaneDetails;
            var flightDetails = ses.FlightDetails;
            var returnDetails = ses.Type == "Round Trip" ? ses.ReturnAirplaneDetails : null;

            departureDetails.TryGetValue("Departure Date", out var departureDate);
            departureDetails.TryGetValue("Departure Time", out var departureTime);
            departureDetails.TryGetValue("Arrival Date", out var arrivalDate);
            departureDetails.TryGetValue("Arrival Time", out var arrivalTime);
            departureDetails.TryGetValue("Departure Airport Code", out var departureAirportCode);
            flightDetails.TryGetValue("Departure Airport Location", out var departureAirportLocation);
            departureDetails.TryGetValue("Arrival Airport Code", out var arrivalAirportCode);
            flightDetails.TryGetValue("Arrival Airport Location", out var arrivalAirportLocation);

            ses.FlightDetails.TryGetValue("Seat Class", out var seatClass);
            ses.FlightDetails.TryGetValue("Departure Location", out var departureLocation);
            ses.FlightDetails.TryGetValue("Arrival Location", out var arrivalLocation);

            var ticket = new PopulateTicket
            {
                BookingDate = DateTime.Now.ToString("MM/dd/yyyy"),
                ReferenceNo = ses.transactionID,
                SeatClass = seatClass,
                Departure = departureAirportCode,
                Arrival = arrivalAirportCode,
                DepartureDate = $"{departureDate} {departureTime}",
                ArrivalDate = $"{arrivalDate} {arrivalTime}",
                DepartureDateOnly = departureDate,
                DepartureTimeOnly = departureTime,
                ArrivalDateOnly = arrivalDate,
                ArrivalTimeOnly = arrivalTime,
                TimeDifference = TimeDifference.Substring(0,2),
                AirplaneNumber = ses.DepartureAirplaneNumber,
                DepartureLocation = departureLocation,
                DepartureAirportLocation = departureAirportLocation,
                ArrivalLocation = arrivalLocation,
                ArrivalAirportLocation = arrivalAirportLocation,
            };

            if (ses.Type == "Round Trip" && returnDetails != null)
            {
                returnDetails.TryGetValue("Departure Date", out var returnDepartureDate);
                returnDetails.TryGetValue("Departure Time", out var returnDepartureTime);
                returnDetails.TryGetValue("Departure Airport Code", out var returnDepartureAirportCode);
                returnDetails.TryGetValue("Departure Airport Location", out var returnDepartureAirportLocation);
                returnDetails.TryGetValue("Arrival Airport Code", out var returnArrivalAirportCode);

                ticket.ReturnDeparture = returnDepartureAirportCode;
                ticket.ReturnArrival = returnArrivalAirportCode;
                ticket.ReturnDateOnly = returnDepartureDate;
                ticket.ReturnTimeOnly = returnDepartureTime;
                ticket.ReturnAirplaneNumber = ses.ReturnAirplaneNumber;
                ticket.ReturnLocation = departureLocation;
                ticket.ReturnAirportLocation = departureAirportLocation;
            }



            string PassengerName = "{0}";

            string top = $@"<!DOCTYPE html>
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
        src: url(../../Flight Booking/TicketDependencies/KantumruyPro-Bold.ttf) format(""truetype"");
      }}
      @font-face {{
        font-family: ""Kantumruy Pro Regular"";
        src: url(../../Flight Booking/TicketDependencies/KantumruyPro-Regular.ttf) format(""truetype"");
      }}
      @font-face {{
        font-family: ""Kantumruy Pro SemiBold"";
        src: url(../../Flight Booking/TicketDependencies/KantumruyPro-SemiBold.ttf) format(""truetype"");
      }}
      @font-face {{
        font-family: ""Kantumruy Pro Medium"";
        src: url(../../Flight Booking/TicketDependencies/KantumruyPro-Medium.ttf) format(""truetype"");
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
    </style>";


            string template = $@"<div class=""logo"" style=""height: 1.3in; display: flex; justify-content: center; align-items: center"">
      <img
        src=""{logoPath}""
      />
    </div>

    <div class=""header"">
      <p>E-TICKET RECEIPT AND ITINERARY</p>
    </div>

    <div class=""main"">
      <section class=""First"" style=""width: 7.2in"">
        <div style=""display: flex; align-items: center"">
          <img src=""{checkCirclePath}"" />
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
          <p class=""content"">{ticket.BookingDate}</p>
          <p class=""content"">{ticket.ReferenceNo}</p>
          <p class=""content"">{ticket.SeatClass}</p>
        </div>
        <hr />
      </section>
      <section>
        <h1>Passenger Name: {PassengerName}</h1>
        <h1 style=""margin-bottom: 10px"">Booking Details</h1>
        <section class=""BookingDetails"">
          <div class=""maindiv"" style=""width: 7.2in; padding: 15px 30px"">
            <img
              src=""{borderPath}""
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
                font-size: 24px;
                font-family: 'Kantumruy Pro Bold';
              ""
            >
              {ticket.Departure} - {ticket.Arrival}
            </p>
            <p style=""font-size: 17px; font-family: 'Kantumruy Pro Regular'"">
              {ticket.DepartureDate} - {ticket.ArrivalDate}
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
                  padding-right: 50px;
                  border-right: 1px solid darkgray
                ""
              >
                <p>{ticket.DepartureDateOnly}</p>
                <p>{ticket.DepartureTimeOnly}</p>
                <p style=""margin-top: 30px; margin-bottom: 30px"">
                  {ticket.TimeDifference}   H   
                </p>
                <p>{ticket.ArrivalDateOnly}</p>
                <p>{ticket.ArrivalTimeOnly}</p>
              </div>

              <div style=""margin-left: 50px"">
                <p style=""margin-bottom: 5px"">FLIGHT NO. {ticket.AirplaneNumber}</p>
                <p style=""font-family: 'Kantumruy Pro Medium'; color: darkgray"">
                  DEPARTURE
                </p>
                <p style=""font-family: 'Kantumruy Pro SemiBold'"">
                  {ticket.DepartureLocation}
                </p>
                <p
                  style=""font-family: 'Kantumruy Pro Regular'; color: darkgray""
                >
                  {ticket.DepartureAirportLocation}
                </p>
                <br />
                <p style=""font-family: 'Kantumruy Pro Medium'; color: darkgray"">
                  ARRIVAL
                </p>
                <p style=""font-family: 'Kantumruy Pro SemiBold'"">
                  {ticket.ArrivalLocation}
                </p>
                <p
                  style=""font-family: 'Kantumruy Pro Regular'; color: darkgray""
                >
                  {ticket.ArrivalAirportLocation}
                </p>
              </div>
            </div>

            <!-- For Return -->
            <div style = ""display: {Return}"">
            <p
              style=""
                color: #763aee;
                font-size: 24px;
                font-family: 'Kantumruy Pro Bold';
              ""
            >
              {ticket.ReturnDeparture} - {ticket.ReturnArrival}
            </p>
            <p style=""font-size: 17px; font-family: 'Kantumruy Pro Regular'"">
              {ticket.DepartureDate} - {ticket.ArrivalDate}
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
                  padding-right: 50px;
                  border-right: 1px solid darkgray
                ""
              >
                <p>{ticket.ReturnDateOnly}</p>
                <p>{ticket.ReturnTimeOnly}</p>
              </div>
              <div style=""margin-left: 50px; border: 0px 0px 1px 0px solid black"">
                <p style=""margin-bottom: 5px"">FLIGHT NO. {ticket.ReturnAirplaneNumber}</p>
                <p style=""font-family: 'Kantumruy Pro Medium'; color: darkgray"">
                  RETURNING TO
                </p>
                <p style=""font-family: 'Kantumruy Pro SemiBold'"">
                  {ticket.ReturnLocation}
                </p>
                <p
                  style=""font-family: 'Kantumruy Pro Regular'; color: darkgray""
                >
                  {ticket.ReturnAirportLocation}
                </p>
              </div>
            </div>
            </div>
          </div>
        </section>
      </section>
    </div>";


            string PageBreak = $@"<div style = ""page-break-before: always""></div>";

            string end = $@"

  </body>
</html>
";


            htmlContent.Append(top);
            for (int i = 0; i < PassengerNames.Count; i++)
            {
                string currentTemplate = template.Replace(PassengerName, PassengerNames[i]);

                htmlContent.Append(currentTemplate);
                htmlContent.Append(PageBreak);
            }

            htmlContent.Append(end);




            // Convert HTML to PDF
            using (FileStream pdfStream = new FileStream(pdfFilePath, FileMode.Create))
            {
                var fontProvider = new DefaultFontProvider(false, false, false);
                fontProvider.AddFont(Path.GetFullPath("../../Flight Booking/TicketDependencies/KantumruyPro-Bold.ttf"));
                fontProvider.AddFont(Path.GetFullPath("../../Flight Booking/TicketDependencies/KantumruyPro-Regular.ttf"));
                fontProvider.AddFont(Path.GetFullPath("../../Flight Booking/TicketDependencies/KantumruyPro-SemiBold.ttf"));
                fontProvider.AddFont(Path.GetFullPath("../../Flight Booking/TicketDependencies/KantumruyPro-Medium.ttf"));
                var properties = new ConverterProperties();
                properties.SetFontProvider(fontProvider);

                HtmlConverter.ConvertToPdf(htmlContent.ToString(), pdfStream, properties);
            }

            Console.WriteLine("PDF created successfully at: " + pdfFilePath);
        }

        private static string ConvertImageToBase64(string imagePath)
        {
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            return $"data:image/{Path.GetExtension(imagePath).Replace(".", "")};base64,{Convert.ToBase64String(imageBytes)}";
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
    }

}

