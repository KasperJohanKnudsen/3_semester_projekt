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

        public BookingLogic()
        {
            _bAccess = new BookingService();
        }

        public async Task<List<Booking>> GetAllBookings()
        {
            List<Booking> foundBookings = await _bAccess.GetBookings();
            return foundBookings;



        }

        public async Task<int> SaveBooking(Booking abooking)
        {
            //Booking newBooking = new Booking(price, seatsBooked);
            //newBooking.BookingOrder = "33";
            int insertedId = await _bAccess.SaveBooking(abooking);
            return insertedId;
        }


    }
}

