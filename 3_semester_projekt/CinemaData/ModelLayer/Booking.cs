using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PhoneNumber { get; set; }
        public int ShowingId { get; set; }
        public decimal Price { get; set; }
        
        public List<SeatBooking> SeatBookings { get; set; }
        
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
        public Booking(decimal price)
        {
            Price = price;
        }
        public Booking(int phoneNumber, int showingId, decimal price) : this(price)
        {

            PhoneNumber = phoneNumber;
            ShowingId = showingId;
            Price = price;

        }

        /*
        public Booking(int id, int userId, int showingId, decimal price, string seatsBooked, int seatbookingId) : this(price, seatsBooked)
        {
            Id = id;
            UserId = userId;
            ShowingId = showingId;
            Price = price;
            SeatsBooked = seatsBooked;
            SeatBookingId = seatbookingId;
        }
        */

        public Booking(int id, int phoneNumber, int showingId, decimal price, List<SeatBooking> seatBookings) : this(price)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            ShowingId = showingId;
            Price = price;
            SeatBookings = seatBookings;
        }

        public Booking(int id, int phoneNumber, int showingId, decimal price) : this(price)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            ShowingId = showingId;
            Price = price;
        }
    }
}
