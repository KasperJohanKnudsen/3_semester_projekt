using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.Controllers
{
    [Route("api/seatbookings")]
    [ApiController]

    public class SeatBookingsController
    {
        private readonly SeatBookingDataControl;
        
        [HttpPost]
        public ActionResult<int> PostNewBooking(BookingdataCreateDto inBooking)
        {
            ActionResult<int> foundReturn;
            int insertedId = -1;
            if (inBooking != null)
            {
                Booking dbBooking = ModelConversion.BookingCreateDtoConvert.ToBooking(inBooking);
                insertedId = _bControl.Add(dbBooking);
            }
            if (insertedId > 0)
            {
                foundReturn = Ok(insertedId);
            }
            else
            {
                foundReturn = new StatusCodeResult(500);
                // Internal server error
            }

            return foundReturn;

        }
    }
}
