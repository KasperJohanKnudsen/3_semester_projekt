using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WebClientMVC.BusinessLogicLayer;
using WebClientMVC.Models;

namespace WebClientMVC.Controllers
{
    public class BookingsController : Controller
    {
        readonly BookingLogic _bookingLogic;

        public BookingsController()
        {
            _bookingLogic = new BookingLogic();
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            
            List<Booking> foundBookings = await _bookingLogic.GetAllBookings();
            return View(foundBookings);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Booking aBooking)
        {
            try
            {
                //bool wasOk = await _bookingLogic.SaveBooking(aBooking);


                int insertedId = -1;
                //decimal price = 100.0m;
                //string seatsBooked = "Row: 666, Seat 1";



                insertedId = await _bookingLogic.SaveBooking(aBooking);

                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

       
       
    }
}
