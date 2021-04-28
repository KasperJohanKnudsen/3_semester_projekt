using APIAccess.ControlLayer;
using CinemaData.ModelLayer;
using CinemaService.BusinesslogicLayer;
using CinemaService.Controllers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.BusinessLogicLayer
{
    public class BookShowingController
    {
        private readonly IConfiguration _configuration;
        private readonly ShowingDataControl _sControl;

        public BookShowingController()
        {
            _sControl = new ShowingDataControl(_configuration);
        }


        public int BookShowing(int showingId, List<SeatBooking> newSeatBookings)
        {
            int insertedId = 0;
            SeatBookingDataControl sDataControl = new SeatBookingDataControl(_configuration);
            BookingdataControl bDataControl = new BookingdataControl(_configuration);
            // Transaction

            //Booking aBooking = BookingsController();

            bool wasOk = sDataControl.Put(showingId, newSeatBookings);


            return insertedId;
        }
    }
}
