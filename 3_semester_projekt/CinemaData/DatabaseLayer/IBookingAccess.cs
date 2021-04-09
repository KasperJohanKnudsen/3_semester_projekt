
using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public interface IBookingAccess
    {
        Booking GetBookingById(int id);
        List<Booking> GetBookingAll();
        int CreateBooking(Booking bookingToAdd);
        bool UpdateBooking(Booking bookingToUpdate);
        bool DeleteBookingById(int id);

    }
}
