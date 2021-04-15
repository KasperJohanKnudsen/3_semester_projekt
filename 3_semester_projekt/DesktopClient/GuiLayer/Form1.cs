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
        ShowingControl _showingControl;
        public Form1()
        {
            InitializeComponent();

            _bookingControl = new BookingControl();
            _showingControl = new ShowingControl();
        }

        private async void buttonGetBookings_Click(object sender, EventArgs e)
        {
            string processText = "OK"; 
            List<Showing> fetchedShowings = await _showingControl.GetAllShowings(); 
            if (fetchedShowings != null) 
            { 
                if (fetchedShowings.Count >= 1) 
                { 
                    processText = "Ok";
                }
                else 
                {
                    processText = "Ingen forestillinger fundet";
                }
            }
            else 
            {
                processText = "Fejl: Der er sket en fejl";
            }
            labelProcessText.Text = processText; 
            listBoxShowings.DataSource = fetchedShowings;
        
    
        }

        private async void BuyButton_Click(object sender, EventArgs e)
        {
            int insertedId = -1;
            decimal price = 100.0m;
            string seatsBooked = "Row: 5, Seat 1";

            insertedId = await _bookingControl.SaveBooking(price, seatsBooked);


            /*
            string messageText;
            // Values from testboxes must be fetched
            string inFirstName = textBoxFirstname.Text;
            string inLastName = textBoxLastname.Text;
            string inEmail = textBoxEmail.Text;
            // Evaluate and act accordingly
            if (InputIsOk(inFirstName, inLastName, inEmail)) 
            {                
                // Call the ControlLayer to get the data saved
                insertedId = await _personControl.SavePerson(inFirstName, inLastName, inEmail);
                messageText = (insertedId > 0) ? $"Person saved with no {insertedId}" : "Failure: An error occurred!";
            } 
            else 
            {                
                messageText = "Please input valid informations";
            }            // Finally put out a message saying if the saving went well
                         labelProcessSave.Text = messageText;
            */
        }
    }
}
