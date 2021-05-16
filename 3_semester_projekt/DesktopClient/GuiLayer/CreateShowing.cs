using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DesktopClient.ControlLayer;


namespace DesktopClient {
    public partial class CreateShowing : Form {
        ShowingControl _showingControl;
        public CreateShowing() {
            InitializeComponent();

            _showingControl = new ShowingControl();
        }

        private async void CreateShowingSubmit_Click(object sender, EventArgs e) {
            int insertedId = -1;
            string movie = SelectMovieBox.Text;
            string theater = SelectTheaterBox.Text;
            DateTime date = monthCalendar1.SelectionRange.Start;
            insertedId = await _showingControl.CreateShowing(movie, theater, date);
            if (insertedId == -1) {
                ErrorLbl.Text = "Der skete en fejl under oprettelse.";
            }
            else {
                System.Diagnostics.Debug.WriteLine(insertedId);
                ErrorLbl.Text = "Showing er oprettet";
            }

        }
    }
}
