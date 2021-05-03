using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.Buffer
{
    public class SeatBookingBuffer
    {
        public int ShowingId { get; set; }
        public int PhoneNumber { get; set; }
        public string SeatsBooked { get; set; }

        public SeatBookingBuffer(int showingId, int phoneNumber, string seatsBooked)
        {
            showingId = ShowingId;
            phoneNumber = PhoneNumber;
            seatsBooked = SeatsBooked;
        }
    }
}
