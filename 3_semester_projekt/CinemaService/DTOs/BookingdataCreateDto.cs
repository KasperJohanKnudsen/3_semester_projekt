using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.DTOs
{
    public class BookingdataCreateDto
    {
        public decimal Price { get; set; }
        public string SeatsBooked { get; set; }

        public BookingdataCreateDto() { }
        public BookingdataCreateDto(decimal price, string seatsBooked)
        {
            Price = price;
            SeatsBooked = seatsBooked;
        }
    }
}
