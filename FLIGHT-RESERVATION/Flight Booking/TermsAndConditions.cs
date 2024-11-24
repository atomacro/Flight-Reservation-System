using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    public partial class TermsAndConditions : Form
    {
        public TermsAndConditions()
        {
            InitializeComponent();
        }

        private void TermsAndConditions_Load(object sender, EventArgs e)
        {

            StringBuilder termsAndConditions = new StringBuilder();
            termsAndConditions.AppendLine("Terms and Conditions for Airplane Ticketing System:");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("1. Ticket Validity:");
            termsAndConditions.AppendLine("   - Tickets are non-transferable and valid only for the passenger named on the ticket.");
            termsAndConditions.AppendLine("   - Tickets must be used in the sequence they are booked (e.g., from origin to destination).");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("2. Cancellation and Refund Policy:");
            termsAndConditions.AppendLine("   - Refunds for canceled tickets are subject to cancellation fees as per airline policy.");
            termsAndConditions.AppendLine("   - Non-refundable tickets will not be eligible for refunds.");
            termsAndConditions.AppendLine("   - Refunds may take up to 14 business days to process.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("3. Check-In Requirements:");
            termsAndConditions.AppendLine("   - Passengers must check in at least 2 hours before the scheduled departure for domestic flights");
            termsAndConditions.AppendLine("     and 3 hours for international flights.");
            termsAndConditions.AppendLine("   - Failure to check in on time may result in denied boarding without a refund.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("4. Baggage Policy:");
            termsAndConditions.AppendLine("   - Passengers are entitled to one carry-on bag and one personal item, subject to size and weight restrictions.");
            termsAndConditions.AppendLine("   - Checked baggage may incur additional fees based on the weight and size of the luggage.");
            termsAndConditions.AppendLine("   - The airline is not liable for lost or damaged baggage unless insurance is purchased.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("5. Flight Changes and Delays:");
            termsAndConditions.AppendLine("   - The airline reserves the right to reschedule, delay, or cancel flights due to weather conditions,");
            termsAndConditions.AppendLine("     technical issues, or unforeseen circumstances.");
            termsAndConditions.AppendLine("   - Passengers are entitled to rescheduling options in case of delays exceeding 4 hours or cancellations.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("6. Passenger Conduct:");
            termsAndConditions.AppendLine("   - Passengers must comply with all safety instructions provided by airline personnel.");
            termsAndConditions.AppendLine("   - Disruptive behavior may result in removal from the flight without refund.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("7. Travel Documentation:");
            termsAndConditions.AppendLine("   - Passengers are responsible for ensuring they have valid passports, visas, and other travel documents");
            termsAndConditions.AppendLine("     required for their destination.");
            termsAndConditions.AppendLine("   - The airline is not responsible for denied boarding due to incomplete or invalid travel documentation.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("8. Health and Safety:");
            termsAndConditions.AppendLine("   - Passengers with specific medical conditions or disabilities must notify the airline at least 48 hours");
            termsAndConditions.AppendLine("     before departure.");
            termsAndConditions.AppendLine("   - Mask-wearing may be mandatory depending on local and airline health regulations.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("9. Liability Limitations:");
            termsAndConditions.AppendLine("   - The airline's liability for loss, injury, or damage is limited by applicable laws and international conventions.");
            termsAndConditions.AppendLine();
            termsAndConditions.AppendLine("10. Acceptance of Terms:");
            termsAndConditions.AppendLine("    - By booking a ticket, passengers agree to abide by these Terms and Conditions and any additional policies set forth by the airline.");


            String terms = termsAndConditions.ToString();
            lblTerms.Text = terms;
        
        
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

        }

        private void lblTerms_Click(object sender, EventArgs e)
        {

        }
    }
}
