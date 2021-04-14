using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Showing
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Date { get; set; }
        public int SeatBookingId { get; set; }


        public Showing() { }
        public Showing(DateTime startTime, DateTime date)
        {
            StartTime = startTime;
            Date = date;
        }
        public Showing(int movieId, int theaterId, DateTime startTime, DateTime date, int seatbookingId) : this(startTime, date)
        {

            MovieId = movieId;
            TheaterId = theaterId;
            StartTime = startTime;
            Date = date;
            SeatBookingId = seatbookingId;
        }
        public Showing(int id, int movieId, int theaterId, DateTime startTime, DateTime date, int seatbookingId) : this(startTime, date)
        {
            ID = id;
            MovieId = movieId;
            TheaterId = theaterId;
            StartTime = startTime;
            Date = date;
            SeatBookingId = seatbookingId;
        }
    }
}
