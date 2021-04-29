using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ShowingId { get; set; }
        public int PhoneNumber { get; set; }

        public decimal Price { get; set; }
        public string SeatsBooked { get; set; }
        public int SeatBookingId { get; set; }
        
        /*
        public bool IsBookingEmpty
        {
            get
            {
                if (String.IsNullOrWhiteSpace(Name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        */

        public Booking() { }
        public Booking(decimal price, string seatsBooked)
        {
            Price = price;
            SeatsBooked = seatsBooked;
        }
        public Booking(int userId, int showingId, decimal price, string seatsBooked, int seatbookingId) : this(price, seatsBooked)
        {

            UserId = userId;
            ShowingId = showingId;
            Price = price;
            SeatsBooked = seatsBooked;
            SeatBookingId = seatbookingId;
        }

        public Booking(int id, int userId, int showingId, decimal price, string seatsBooked, int seatbookingId) : this(price, seatsBooked)
        {
            Id = id;
            UserId = userId;
            ShowingId = showingId;
            Price = price;
            SeatsBooked = seatsBooked;
            SeatBookingId = seatbookingId;
        }
    }
}
