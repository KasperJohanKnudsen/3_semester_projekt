using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopClient.ModelLayer
{
    public class Showing
    {
        public string MovieName { get; set; }
        public string Theater { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Date { get; set; }
        public string ShowingOrder { get; set; }

        public Showing() { }

        public Showing(string movieName, string theater, DateTime startTime, DateTime date)
        {
            MovieName = movieName;
            Theater = theater;
            StartTime = startTime;
            Date = date;
        }
        public override string ToString()
        {
            string sText = ShowingOrder;

            return sText;
        }
    }
}
