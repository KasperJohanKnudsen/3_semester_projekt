using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Showing : Model
    {
        //public int ID { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public DateTime ShowTime { get; set; }
        public int TheaterId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Date { get; set; }
        public int SeatBookingId { get; set; }
        public List<SeatBooking> SeatBookings { get; set; }


        public Showing() { }
        public Showing(DateTime startTime, DateTime date)
        {
            StartTime = startTime;
            Date = date;
        }
        public Showing(int movieId, int theaterId, DateTime startTime, DateTime date) : this(startTime, date)
        {

            MovieId = movieId;
            TheaterId = theaterId;
            StartTime = startTime;
            Date = date;
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

        public Showing(int id, string title, string room, DateTime showTime)
        {
            ID = id;
            Title = title;
            Room = room;
            ShowTime = showTime;
        }
    }
}
