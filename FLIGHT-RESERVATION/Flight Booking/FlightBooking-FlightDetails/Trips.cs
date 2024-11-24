using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    public interface Trips
    {

        //set Name to be accessed by main control
        ComboBox cboArrivalLocationControl { get; }
        ComboBox cboDepartureLocationControl { get; }
        ComboBox cboDepartureDateControl { get; }
        ComboBox cboReturnDateControl { get; }
        
        ComboBox cboClassSeatControl { get; }
        NumericUpDown numAdultControl { get; }
        NumericUpDown numChildrenControl { get; }
        NumericUpDown numInfantsControl { get; }

        Label lblDepartureAirportNameControl { get; }
        Label lblArrivalAirportNameControl { get; }



        
        //methods under this interface
        void SetArrivalLocation(Dictionary<string, string> locations);
        void SetDepartureLocation(Dictionary<string, string> locations);
        void SetDates(HashSet<string> departureDates, HashSet<string> returnDates = null);
    }
}
