using CinemaData.ModelLayer;
using CinemaService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.ModelConversion
{
    public class BookingdataReadDtoConvert
    {
        public static List<BookingdataReadDto> FromBookingCollection(List<Booking> inBookings)
        {
            List<BookingdataReadDto> aBookingReadDtoList = null;
            if (inBookings != null)
            {
                aBookingReadDtoList = new List<BookingdataReadDto>();
                BookingdataReadDto tempDto;
                foreach (Booking aBooking in inBookings)
                {
                    tempDto = FromBooking(aBooking);
                    aBookingReadDtoList.Add(tempDto);
                }
            }
            return aBookingReadDtoList;
        }
        public static BookingdataReadDto FromBooking(Booking inBooking)
        {
            BookingdataReadDto aBookingReadDto = null;
            if (inBooking != null)
            {
                aBookingReadDto = new BookingdataReadDto(inBooking.Price);
                aBookingReadDto.BookingOrder = $"{inBooking.Price}";
                
            }
            return aBookingReadDto;
        }
    }
}
