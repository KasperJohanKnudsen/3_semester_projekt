using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.DTOs
{
    public class BookingdataReadDto
    {
        public decimal Price { get; set; }
        public string SeatsBooked { get; set; }

        public string BookingOrder { get; set; }

        public BookingdataReadDto() { }
        public BookingdataReadDto(decimal price, string seatsBooked)
        {
            Price = price;
            SeatsBooked = seatsBooked;
        }
    }
}
