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

        public int ShowId { get; set;}
        public BookingsController()
        {
            ShowId = 1;
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
        /*
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



                insertedId = await _bookingLogic.CreateBooking(aBooking);

                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }
        */

        public async Task<ActionResult> SeatBooking(int? id)
        {
            ShowingLogic sLogic = new ShowingLogic();
            bool withReservations = true;
            int showingIdInt = (id != null) ? ((int)id) : 0;
            Showing foundShowing = await sLogic.GetShowingById(showingIdInt, withReservations);

            string bookText = "Press green seat to reserve seat";
            if (TempData["bookResult"] != null)
            {
                bookText = TempData["bookResult"].ToString();
            }
            ViewBag.PrevResult = bookText;

            // Assigning showId here because the view file seatBooking.cshtml could not find showId
            return View(foundShowing);
        }


        [HttpPost]
        public async Task<ActionResult> SeatBooking(int phoneNumber, int showId, string reservedSeats)
        {
            //BookingLogic bLogic = new BookingLogic();


            // Transaction

            //bool wasUpdated = await sLogic.UpdateShowingBookings(showId, reservedSeats, phoneNumber);

            //Booking aBooking = new Booking(phoneNumber, showId, 100.0m, reservedSeats);

            ShowingLogic sLogic = new ShowingLogic();

            try
            {
                //
                //bool wasOk = await _bookingLogic.SaveBooking(aBooking);

                
                int insertedId = -1;
                //decimal price = 100.0m;
                //string seatsBooked = "Row: 666, Seat 1";



                insertedId = await _bookingLogic.CreateBooking(phoneNumber, showId, 100.0m, reservedSeats);
                Showing foundShowing = await sLogic.GetShowingById(showId, true);
                return View("SeatBooking", foundShowing);
                
            }
            catch
            {
                /*
                if (wasUpdated)
                {

                    ViewBag.PrevResult = "Seats was reserved!";
                }
                else
                {
                    ViewBag.PrevResult = "Sorry - not reserved - something went wrong";
                }
                */


                // Transaction End
                Showing foundShowing = await sLogic.GetShowingById(1, true);
                return View("SeatBooking", foundShowing);

            }
        }

    }



}

