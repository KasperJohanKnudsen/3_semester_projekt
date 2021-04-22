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

        public async Task<List<Showing>> GetAllShowings()
        {
            List<Showing> foundShowings = await _sAccess.GetShowings();
            return foundShowings;



        }
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

        public async Task<int> SaveShowing(Showing aShowing)
        {
            //Booking newBooking = new Booking(price, seatsBooked);
            //newBooking.BookingOrder = "33";
            int insertedId = await _sAccess.SaveShowing(aShowing);
            return insertedId;
        }
    }
}
