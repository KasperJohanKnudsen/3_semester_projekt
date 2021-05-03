using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CinemaData.ModelLayer;
using CinemaService.BusinesslogicLayer;
using CinemaService.DTOs;


namespace CinemaService.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly BookingdataControl _bControl;
        private readonly IConfiguration _configuration;
        public BookingsController(IConfiguration inConfiguration)
        {
            _configuration = inConfiguration;
            _bControl = new BookingdataControl(_configuration);
        }
        // URL: api/bookings
        [HttpGet]
        public ActionResult<List<BookingdataReadDto>> Get()
        {
            ActionResult<List<BookingdataReadDto>> foundReturn;
            // retrieve and convert data
            List<Booking> foundBookings = (List<Booking>)_bControl.Get();
            List<BookingdataReadDto> foundDts = ModelConversion.BookingdataReadDtoConvert.FromBookingCollection(foundBookings);
            // evaluate
            if (foundDts != null)
            {
                if (foundDts.Count > 0)
                {
                    foundReturn = Ok(foundDts);
                    // Statuscode 200
                }
                else
                {
                    foundReturn = new StatusCodeResult(204);
                    // Ok, but no content
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500);
                // Internal server error
            }
            // send response back to client
            return foundReturn;
        }
        // URL: api/bookings/{id}
        [HttpGet, Route("{id}")]
        public ActionResult<BookingdataReadDto> Get(int id)
        {
            ActionResult<BookingdataReadDto> foundReturn;
           
            Booking foundBooking = _bControl.GetById(id);

            BookingdataReadDto foundDt = ModelConversion.BookingdataReadDtoConvert.FromBooking(foundBooking);

            if (foundDt != null)
            {
                    foundReturn = Ok(foundDt);
                    // Statuscode 200
            }
            else
            {
                foundReturn = new StatusCodeResult(500);
                // Internal server error
            }
            // send response back to client
            return foundReturn;

        }
        // URL: 
        [HttpPost]
        public ActionResult<int> PostNewBooking(Booking inBooking)
        {
            //int showId, List< SeatBooking > newSeatBookings

            int showId = inBooking.ShowingId;
            List<SeatBooking> newSeatBookings = inBooking.SeatBookings;
            ActionResult<int> foundReturn;
            int insertedId = -1;
            if (inBooking != null)
            {
                //Booking dbBooking = ModelConversion.BookingCreateDtoConvert.ToBooking(inBooking);
                insertedId = _bControl.Add(inBooking, showId, newSeatBookings);
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
