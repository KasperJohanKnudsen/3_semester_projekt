using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClientMVC.Models;
using WebClientMVC.ServiceLayer;

namespace WebClientMVC.BusinessLogicLayer
{
    public class ShowingLogic
    {
        ShowingService _sAccess;

        public ShowingLogic()
        {
            _sAccess = new ShowingService();
        }
        public async Task<Showing> GetShowingById(int showingId, bool includeSeatReservations)
        {
            Showing retrievedShowing;
            ShowingService sService = new ShowingService();

            try
            {
                retrievedShowing = await sService.GetShowing(showingId, includeSeatReservations);
            }
            catch (Exception)
            {
                retrievedShowing = null;
            }
            return retrievedShowing;
        }

        public async Task<bool> UpdateShowingBookings(int showingId, string changedSeatRes, int userPhoneNumber)
        {
            bool wasUpdatedOk = false;
            ShowingService sService = new ShowingService();

            List<SeatBooking> newReservations = GetSeatBookings(showingId, changedSeatRes, userPhoneNumber);
            try
            {
                wasUpdatedOk = await sService.UpdateSeatBookings(showingId, newReservations);
            }
            catch (Exception)
            {
                wasUpdatedOk = false;
            }
            return wasUpdatedOk;
        }
        /*
        public async Task<List<Showing>> GetAllShowings()
        {
            List<Showing> foundShowings = await _sAccess.GetShowings();
            return foundShowings;



        }
        */
        /*
        public async Task<Showing> GetShowingById(int showingId, bool includeSeatReservations)
        {
            Showing retrievedShowing;
            

            try
            {
                retrievedShowing = await _sAccess.GetShowing(showingId, includeSeatReservations);
            }
            catch (Exception)
            {
                retrievedShowing = null;
            }
            return retrievedShowing;
        }
        */

        private List<SeatBooking> GetSeatBookings(int showingId, string resString, int userPhoneNumber)
        {
            List<SeatBooking> seatBookings = null;
            SeatBooking seatBooking;
            int tempSeatId, rowNo, seatNo;
            bool parseOk;

            if (!string.IsNullOrWhiteSpace(resString))
            {
                seatBookings = new List<SeatBooking>();
                DateTime resTime = DateTime.Now;
                bool reserve = true;
                string[] seatIds = resString.Split(':');
                foreach (string seatId in seatIds)
                {
                    parseOk = int.TryParse(seatId, out tempSeatId);
                    if (parseOk)
                    {
                        rowNo = tempSeatId / 1000;
                        seatNo = tempSeatId - (rowNo * 1000);
                        seatBooking = new SeatBooking(showingId, reserve, rowNo, seatNo, userPhoneNumber);
                        seatBookings.Add(seatBooking);
                    }
                }
            }
            return seatBookings;
        }
        /*
        public async Task<int> SaveShowing(Showing aShowing)
        {
            //Booking newBooking = new Booking(price, seatsBooked);
            //newBooking.BookingOrder = "33";
            int insertedId = await _sAccess.SaveShowing(aShowing);
            return insertedId;
        }
        */
    }
}
