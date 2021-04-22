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

        public async Task<ActionResult> SeatBooking(int? id)
        {
            ShowingLogic showingAccVtrl = new ShowingLogic();
            bool withReservations = true;
            int showingIdInt = (id != null) ? ((int)id) : 0;
            Showing foundShowing = await showingAccVtrl.GetShowingById(showingIdInt, withReservations);

            string bookText = "Press green seat to reserve seat";
            if (TempData["bookResult"] != null)
            {
                bookText = TempData["bookResult"].ToString();
            }
            ViewBag.PrevResult = bookText;

            return View(foundShowing);
        }



    }
}
