using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.DTOs
{
    public class BookingdataCreateDto
    {
        public string Name { get; set; }

        public BookingdataCreateDto() { }
        public BookingdataCreateDto(string name)
        {
            Name = name;
        }
    }
}
