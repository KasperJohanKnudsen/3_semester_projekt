using System;
using System.Collections.Generic;
using CinemaData.ModelLayer;
using CinemaData.DatabaseLayer;
using Microsoft.Extensions.Configuration;
using CinemaService.BusinessLogicLayer;

namespace CinemaService.BusinesslogicLayer
{
    public class BookingdataControl
    {

        //ICRUD<Booking> _bookingAccess;
        BookingDatabaseAccess _bookingAccess;
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
        public int Add(Booking newBooking, int showingId, List<SeatBooking> newSeatBookings)
        {
            int insertedId;
            try
            {
                // Assignments below needs to be removed when hardcoding them can be avoided
                //newBooking.UserId = new User().FindIdInList(_userAccess.GetAll());

                //newBooking.ShowingId = new Showing().FindIdInList(_showingAccess.GetAll());

                //newBooking.SeatBookingId = new SeatBooking().FindIdInList(_seatBookingAccess.GetAll());

                // newBooking.PhoneNumber = sbBufferList.PhoneNumber;
                // newBooking.ShowingId = sbBufferList.ShowingId;
                // newBooking.SeatsBooked = sbBufferList.SeatsBooked;
                
                newBooking.Price = 100.0m;

                insertedId = _bookingAccess.Create(newBooking, showingId, newSeatBookings);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking GetById(int idToMatch)
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

        public bool Put(int id, List<Booking> entitiesToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}