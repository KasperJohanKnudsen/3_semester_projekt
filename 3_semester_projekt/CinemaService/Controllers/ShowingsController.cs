using CinemaData.ModelLayer;
using CinemaService.BusinessLogicLayer;
using CinemaService.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class ShowingsController : ControllerBase
    {
        private readonly ShowingDataControl _sControl;

        private readonly IConfiguration _configuration;
        public ShowingsController(IConfiguration inConfiguration)
        {
            _configuration = inConfiguration;
            _sControl = new ShowingDataControl(_configuration);
        }

        [HttpGet]
        public IActionResult Get() {
            IActionResult foundReturn;
            // retrieve and convert data
            List<Showing> foundShowings = (List<Showing>)_sControl.Get();

            // evaluate
            if (foundShowings != null) {
                if (foundShowings.Count > 0) {
                    foundReturn = Ok(foundShowings);
                    // Statuscode 200
                }
                else {
                    foundReturn = new StatusCodeResult(204);
                    // Ok, but no content
                }
            }
            else {
                foundReturn = new StatusCodeResult(500);
                // Internal server error
            }
            // send response back to client
            return foundReturn;
        }

        // URL: api/bookings
        /*
        [HttpGet]
        public ActionResult<List<ShowingdataReadDto>> Get()
        {
            ActionResult<List<ShowingdataReadDto>> foundReturn;
            // retrieve and convert data
            List<Showing> foundShowings = (List<Showing>)_sControl.Get();
            List<ShowingdataReadDto> foundDts = ModelConversion.ShowingReadDtoConvert.FromShowingCollection(foundShowings);
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
        
        [HttpGet, Route("{id}")]
        public ActionResult<ShowingdataReadDto> Get(int id)
        {
            ActionResult<ShowingdataReadDto> foundReturn;

            Showing foundShowing = _sControl.GetById(id);

            ShowingdataReadDto foundDt = ModelConversion.ShowingReadDtoConvert.FromShowing(foundShowing);

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
        */



        [HttpGet, Route("showings/{showingId}")]
        public IActionResult Get(int showingId = 0, bool includeReservations = false)
        {
            IActionResult foundToReturn;
            Showing foundShowing;
            List<SeatBooking> seatBookings;

            ShowingDataControl sControl = new ShowingDataControl(_configuration);
            SeatBookingDataControl sbControl = new SeatBookingDataControl(_configuration);

            foundShowing = sControl.GetShowingViewById(showingId);
            if(foundShowing != null && includeReservations)
            {
                seatBookings = sbControl.GetSeatBookings(showingId);
                if(seatBookings != null)
                {
                    foundShowing.SeatBookings = seatBookings;
                }
                else
                {
                    foundToReturn = new StatusCodeResult(500);
                }
            }
            if (foundShowing != null)
            {
                foundToReturn = Ok(foundShowing);
            }
            else
            {
                foundToReturn = NotFound();
            }
            return foundToReturn;
            

        }

        [HttpDelete, Route("showings/{showingId}")]
        public IActionResult Delete(int showingId)
        {
            IActionResult foundToReturn;
            ShowingDataControl showingDataControl = new ShowingDataControl(_configuration);
            bool wasOk = showingDataControl.Delete(showingId);
            if (wasOk)
            {
                foundToReturn = Ok();
            }
            else
            {
                foundToReturn = new StatusCodeResult(200);
            }

            return foundToReturn;


        }


        [HttpGet]
        [Route("showings/{showingId}/seatbookings")]
        public IActionResult GetShowingSeatBookings (int showingId)
        {
            IActionResult foundToReturn;
            List<SeatBooking> foundSeatBookings;

            SeatBookingDataControl sControl = new SeatBookingDataControl(_configuration);

            foundSeatBookings = sControl.GetSeatBookings(showingId);
            if(foundSeatBookings != null && foundSeatBookings.Count > 0)
            {
                foundToReturn = Ok(foundSeatBookings);
            }
            else
            {
                foundToReturn = NotFound();
            }

            if (foundSeatBookings == null)
            {
                foundToReturn = new StatusCodeResult(500);
            }
            return foundToReturn;
        }

        [HttpPut, Route("showings/{showingId}/seatbookings")]
        public IActionResult UpdateShowingSeatBookings(int showingId, List<SeatBooking> newSeatBookings)
        {
            IActionResult foundToReturn;
            SeatBookingDataControl sDataControl = new SeatBookingDataControl(_configuration);
            bool wasOk = sDataControl.Put(showingId, newSeatBookings);

            //_bookShowingController.BookShowing(showingId, newSeatBookings);


            if(wasOk)
            {
                foundToReturn = Ok();
            }
            else
            {
                foundToReturn = new StatusCodeResult(200);
            }

            return foundToReturn;
        }
    }
}
