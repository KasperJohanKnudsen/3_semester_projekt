using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopClient.ModelLayer
{
    public class Booking
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string SeatsBooked { get; set; }
        public string BookingOrder { get; set; }

        public Booking() { }
        public Booking(decimal price, string seatsBooked)
        {
            Price = price;
            SeatsBooked = seatsBooked;
        }
 
        public override string ToString()
        {
            string bText = BookingOrder;
            
            return bText;
        }
    }
}
