using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClientMVC.Models;
using WebClientMVC.ServiceLayer;

namespace WebClientMVC.BusinessLogicLayer
{
    public class BookingLogic
    {
        BookingService _bAccess;

        public BookingLogic()
        {
            _bAccess = new BookingService();
        }

        public async Task<List<Booking>> GetAllBookings()
        {
            List<Booking> foundBookings = await _bAccess.GetBookings();
            return foundBookings;



        }

        public async Task<int> CreateBooking(int phoneNumber, int showId, decimal price, string seatsBooked)
        {

            // 
            List<SeatBooking> newReservations = GetSeatBookings(showId, seatsBooked, phoneNumber);
           
            Booking bookingToSave = new Booking(phoneNumber, showId, 100.0m, newReservations);



            int insertedId = await _bAccess.SaveBooking(bookingToSave);
            return insertedId;
        }
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
    }
}

