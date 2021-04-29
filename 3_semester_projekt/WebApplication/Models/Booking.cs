using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientMVC.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int ShowingId { get; set; }
        public decimal Price { get; set; }
        public string SeatsBooked { get; set; }
        public string BookingOrder { get; set; }
        public string Rowbooked { get; set; }
        public string SeatsBookedOnRow { get; set; }
        public int PhoneNumber { get; set; }
        public List<SeatBooking> SeatBookings { get; set; }


        public Booking() { }
        /*
        public Booking(decimal price, string seatsBooked)
        {
            Price = price;
            SeatsBooked = seatsBooked;
        }
        */
        public Booking(int phoneNumber, decimal price, string seatsBooked)
        {
            PhoneNumber = phoneNumber;
            Price = price;
            SeatsBooked = seatsBooked;
            
        }
        
        public Booking(int phoneNumber, string rowBooked, string seatsBookedOnRow, string seatsBooked)
        {
            PhoneNumber = phoneNumber;

            seatsBooked = rowBooked + seatsBookedOnRow;
            SeatsBooked = seatsBooked;
        }

        public Booking(int phoneNumber, string reservedSeats, int showingId)
        {
            PhoneNumber = phoneNumber;
            Rese

            seatsBooked = rowBooked + seatsBookedOnRow;
            SeatsBooked = seatsBooked;
        }





        public override string ToString()
        {
            string bText = BookingOrder;

            return bText;
        }

        public enum Rows {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4
        }


        public enum SeatOnRow {
            One = 1,
            Two = 2,
            Three = 3
        }
    }
}
