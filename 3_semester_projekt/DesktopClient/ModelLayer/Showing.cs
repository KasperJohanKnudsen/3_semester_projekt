using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopClient.ModelLayer
{
    public class Showing
    {
        public string MovieName { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public string Theater { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Date { get; set; }
        public string ShowingOrder { get; set; }

        public Showing() { }

        public Showing(int movieId, int theaterId, DateTime startTime, DateTime date) {
            MovieId = movieId;
            TheaterId = theaterId;
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
