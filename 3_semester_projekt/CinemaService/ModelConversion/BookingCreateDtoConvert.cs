using CinemaData.ModelLayer;
using CinemaService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.ModelConversion
{
    public class BookingCreateDtoConvert
    {
        public static Booking ToBooking(BookingdataCreateDto inDto)
        {
            Booking aBooking = null;
            if (inDto != null)
            {
                aBooking = new Booking(inDto.Price, inDto.SeatsBooked);
            }
            return aBooking;
        }
    }
}

