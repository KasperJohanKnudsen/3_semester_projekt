using System;
using System.Collections.Generic;
using CinemaData.ModelLayer;
using CinemaData.DatabaseLayer;
using Microsoft.Extensions.Configuration;
using CinemaService.BusinessLogicLayer;

namespace CinemaService.BusinesslogicLayer
{
    public class BookingdataControl : IDataControl<Booking>
    {

        ICRUD<Booking> _bookingAccess;
        public BookingdataControl(IConfiguration inConfiguration)
        {
            _bookingAccess = new BookingDatabaseAccess(inConfiguration);
        }
        public int Add(Booking newBooking)
        {
            int insertedId;
            try
            {
                // Assignments below needs to be removed when hardcoding them can be avoided
                newBooking.UserId = 1;
                newBooking.ShowingId = 1;
                newBooking.SeatBookingId = 1;
                insertedId = _bookingAccess.Create(newBooking);
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
                foundBooking = _bookingAccess.GetById(idToMatch);
            }
            catch
            {
                foundBooking = null;
            }
            return foundBooking;
        }

        public bool Put(Booking entityToUpdate)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Booking> Get()
        {
            List<Booking> foundBookings;
            try
            {
                foundBookings = (List<Booking>)_bookingAccess.GetAll();
            }
            catch
            {
                foundBookings = null;
            }
            return foundBookings;
        }
    }
}