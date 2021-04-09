using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.DTOs
{
    public class BookingdataReadDto
    {
        public string Name { get; set; }

        public BookingdataReadDto() { }
        public BookingdataReadDto(string name)
        {
            Name = name;
        }
    }
}
