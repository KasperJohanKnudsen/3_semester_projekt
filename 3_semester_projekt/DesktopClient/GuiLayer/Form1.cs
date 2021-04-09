using DesktopClient.ControlLayer;
using DesktopClient.ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        BookingControl _bookingControl;
        public Form1()
        {
            InitializeComponent();

            _bookingControl = new BookingControl();
        }

        private async void buttonGetBookings_Click(object sender, EventArgs e)
        {
            string processText = "OK"; 
            List<Booking> fetchedBookings = await _bookingControl.GetAllBookings(); 
            if (fetchedBookings != null) 
            { 
                if (fetchedBookings.Count >= 1) 
                { 
                    processText = "Ok";
                }
                else 
                {
                    processText = "No persons found";
                }
            }
            else 
            {
                processText = "Failure: An error occurred";
            }
            labelProcessText.Text = processText; 
            listBoxBookings.DataSource = fetchedBookings;
        
    
        }
    }
}
