using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.DTOs
{
    public class BookingdataCreateDto
    {
        public decimal Price { get; set; }

        public BookingdataCreateDto() { }
        public BookingdataCreateDto(decimal price)
        {
            Price = price;
        }
    }
}
