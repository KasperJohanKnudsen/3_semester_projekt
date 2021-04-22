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
    [Route("api/showings")]
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
        // URL: api/bookings
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

    }
}
