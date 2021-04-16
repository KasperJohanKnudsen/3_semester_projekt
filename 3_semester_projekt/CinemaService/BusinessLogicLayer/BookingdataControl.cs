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
        ICRUD<User> _userAccess;
        ICRUD<Showing> _showingAccess;
        ICRUD<SeatBooking> _seatBookingAccess;
        public BookingdataControl(IConfiguration inConfiguration)
        {
            _bookingAccess = new BookingDatabaseAccess(inConfiguration);
            _userAccess = new UserDatabaseAccess(inConfiguration);
            _showingAccess = new ShowingDatabaseAccess(inConfiguration);
            _seatBookingAccess = new SeatBookingDatabaseAccess(inConfiguration);
        }
        public int Add(Booking newBooking)
        {
            int insertedId;
            try
            {
                // Assignments below needs to be removed when hardcoding them can be avoided

                newBooking.UserId = FindTempId(_userAccess.GetAll());
                newBooking.ShowingId = FindTempId(_showingAccess.GetAll());
                newBooking.SeatBookingId = FindTempId(_seatBookingAccess.GetAll());

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

        private int FindTempId(IEnumerable<User> list)
        {
            int tempId = 0;
            foreach (var obj in list)
            {
                return obj.UserId;
            }

            return tempId;
        }

        private int FindTempId(IEnumerable<Showing> list)
        {
            int tempId = 0;
            foreach (var obj in list)
            {
                return obj.ID;
            }

            return tempId;
        }
        private int FindTempId(IEnumerable<SeatBooking> list)
        {
            int tempId = 0;
            foreach (var obj in list)
            {
                return obj.ID;
            }

            return tempId;
        }
    }
}