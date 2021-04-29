using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClientMVC.Models;
using WebClientMVC.ServiceLayer;

namespace WebClientMVC.BusinessLogicLayer
{
    public class BookingLogic
    {
        BookingService _bAccess;
        ShowingLogic _sLogic;

        public BookingLogic()
        {
            _bAccess = new BookingService();
            _sLogic = new ShowingLogic();
        }

        public async Task<List<Booking>> GetAllBookings()
        {
            List<Booking> foundBookings = await _bAccess.GetBookings();
            return foundBookings;



        }

        public async Task<bool> CreateBooking(int showingId, int phoneNumber, string seatsBooked)
        {

            // 
            bool wasReservedOk = false;
            ShowingService sService = new ShowingService();

            List<SeatBooking> newReservations = _sLogic.GetSeatBookings(showingId, seatsBooked, phoneNumber);
            try
            {
                wasReservedOk = await _bAccess.SaveBooking(showingId, seatsBooked, phoneNumber);
            }
            catch (Exception)
            {
                wasReservedOk = false;
            }
            return wasReservedOk;

            Booking bookingToSave = new Booking(showingId, phoneNumber, seatsBooked);



            int insertedId = await _bAccess.SaveBooking(bookingToSave);
            
        }
    }
}

