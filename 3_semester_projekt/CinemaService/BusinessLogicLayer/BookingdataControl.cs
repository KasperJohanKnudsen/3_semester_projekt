using System;
using System.Collections.Generic;
using CinemaData.ModelLayer;
using CinemaData.DatabaseLayer;
using Microsoft.Extensions.Configuration;

namespace CinemaService.BusinesslogicLayer
{
    public class BookingdataControl : IBookingData
    {

        IBookingAccess _bookingAccess;
        public BookingdataControl(IConfiguration inConfiguration)
        {
            _bookingAccess = new BookingDatabaseAccess(inConfiguration);
        }
        public int Add(Booking newBooking)
        {
            int insertedId;
            try
            {
                insertedId = _bookingAccess.CreateBooking(newBooking);
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int idToMatch)
        {
            Booking foundBooking;
            try
            {
                foundBooking = _bookingAccess.GetBookingById(idToMatch);
            }
            catch
            {
                foundBooking = null;
            }
            return foundBooking;
        }

        public List<Booking> Get()
        {
            List<Booking> foundBookings;
            try
            {
                foundBookings = _bookingAccess.GetBookingAll();
            }
            catch
            {
                foundBookings = null;
            }
            return foundBookings;
        }

        public bool Put(Booking bookingToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}