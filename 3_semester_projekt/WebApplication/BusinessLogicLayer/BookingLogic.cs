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

        public async Task<int> CreateBooking(int phoneNumber, decimal price, string seatsBooked)
        {
            
            // 
            
            Booking bookingToSave = new Booking(phoneNumber, price, seatsBooked);



            int insertedId = await _bAccess.SaveBooking(bookingToSave);
            return insertedId;
        }
    }
}

