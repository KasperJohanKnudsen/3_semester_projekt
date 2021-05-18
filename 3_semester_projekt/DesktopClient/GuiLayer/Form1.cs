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


        private void EnteredShowingId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            int showingId = 0;
            if (Int32.TryParse(EnteredShowingId.Text, out showingId))
            {
                await _showingControl.Delete(showingId);
            }
            else
            {
                DeleteStatus.Text = "Sletning lykkes ikke";
            }

            
        }

        private void CreateShowingBtn_Click(object sender, EventArgs e) {
            CreateShowing form = new CreateShowing();
            form.Show();
        }
    }
}
