using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientMVC.Models
{
    public class Showing
    {
        public int ShowingId { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Date { get; set; }
        public int SeatBookingId { get; set; }
        public List<SeatBooking> SeatBookings { get; set; }


        public List<int> GetRoomRows()
        {
            List<int> roomRows = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            return roomRows;
        }

        public List<SeatBooking> GetSeatRow(int targetRow)
        {
            List<SeatBooking> SeatsInRow = new List<SeatBooking>();
            foreach (SeatBooking row in SeatBookings)
            {
                if (row.RowNo == targetRow)
                {
                    SeatsInRow.Add(row);
                }
            }
            return SeatsInRow;
        }
    }
}
